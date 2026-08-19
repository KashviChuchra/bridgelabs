using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Text;
using System.Text.RegularExpressions;

namespace EmailCampaign
{
    public class EmailEvent
    {
        public string EventType { get; set; }
        public string Campaign { get; set; }
        public string UserEmail { get; set; }
        public DateTime Timestamp { get; set; }
        public string Device { get; set; }

        private static readonly Regex EventRegex = new Regex(@"^EVENT:(?<eventType>open|click|bounce|unsubscribe)" +@"\|CAMPAIGN:(?<campaign>[^|]+)" +@"\|USER:(?<user>[^|]+)" +@"\|TS:(?<timestamp>[^|]+)" +@"\|DEVICE:(?<device>[^|]+)$",RegexOptions.IgnoreCase);
        
        // regex for multi domain
        private static readonly Regex EmailRegex = new Regex(@"^[a-zA-Z0-9.]*@[a-z]*\.[a-z]*$");

        public static readonly string[] SupportedEvents =
        {
                "open",
                "click",
                "bounce",
                "unsubscribe"
        };
        public EmailEvent(string eventType, string campaign, string useremail, DateTime timestamp, string device)
        {
            if (!SupportedEvents.Contains(eventType.ToLower())) throw new ArgumentException("Event Type Not spported");
            if (!IsValidEmail(useremail)) throw new ArgumentException("emial address not valid");
            EventType = eventType;
            UserEmail = useremail;
            Campaign = campaign;
            Timestamp = timestamp;
            Device = device;
        }

        public bool IsValidEmail(string email)
        {
            if (string.IsNullOrEmpty(email)) return false;
            return EmailRegex.IsMatch(email);
        }
        public static EmailEvent Parse(string raw)
        {
            if (string.IsNullOrEmpty(raw))
            {
                throw new ArgumentException("Event cannot be empty");
            }
            Match match = EventRegex.Match(raw);
            if (!match.Success)
            {
                throw new ArgumentException("Invalid event format");
            }
            string eventTypes = match.Groups["eventType"].Value;
            string campaign = match.Groups["campaign"].Value;
            string timestamptext = match.Groups["timestamp"].Value;
            string useremail = match.Groups["user"].Value;
            string devicename = match.Groups["device"].Value;

            if (!DateTime.TryParse(timestamptext, out DateTime timestamp)) throw new ArgumentException("format of datetime is incorrecr!");
            
            return new EmailEvent
            (
                eventTypes,
                campaign,
                useremail,
                timestamp,
                devicename
            );

        }
       
    }

    //internal class eventsByCampaign : EmailEvent
    //{
    //    public eventsByCampaign(string eventType, string campaign, string useremail, DateTime timestamp, string device) : base(eventType, campaign, useremail, timestamp, device)
    //    {

    //    }
    //}

    //internal class eventsByUser : EmailEvent
    //{
    //    public eventsByUser(string eventType, string campaign, string useremail, DateTime timestamp, string device) : base(eventType, campaign, useremail, timestamp, device)
    //    {

    //    }
    //}


    public class EventStore<T> where T : EmailEvent
    {
        private readonly List<T> allEvents = new List<T>();
        private readonly Dictionary<string, List<T>> eventsByCampaign = new Dictionary<string, List<T>>();
        private readonly Dictionary<string, List<T>> eventsByUser = new Dictionary<string, List<T>>();

        public void Add(T emailEvent)
        {
            allEvents.Add(emailEvent);

            if (!eventsByCampaign.ContainsKey(emailEvent.Campaign))
            {
                eventsByCampaign[emailEvent.Campaign] = new List<T>();
            }

            eventsByCampaign[emailEvent.Campaign].Add(emailEvent);

            if (!eventsByUser.ContainsKey(emailEvent.UserEmail))
            {
                eventsByUser[emailEvent.UserEmail] = new List<T>();
            }

            eventsByUser[emailEvent.UserEmail].Add(emailEvent);
        }

        public IEnumerable<T> GetEventByCampaign(string campaign)
        {
            if (eventsByCampaign.TryGetValue(campaign,out List<T> events))
            {
                return events;
            }

            return new List<T>();
        }

        public IEnumerable<T> GetEventByUser(string userEmail)
        {
            if (eventsByUser.TryGetValue(userEmail,out List<T> events))
            {
                return events;
            }

            return new List<T>();
        }

        public IEnumerable<T> GetAll()
        {
            return allEvents;
        }

        public int Count()
        {
            return allEvents.Count;
        }

    }
}

