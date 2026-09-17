using System;
using System.Collections.Generic;

namespace EmailCampaign
{
    public class EmailCampaignAnalyzer<T> where T : EmailEvent
    {
        private readonly EventStore<T> eventStore;

        public EmailCampaignAnalyzer(EventStore<T> eventStore)
        {
            this.eventStore = eventStore;
        }

        public int GetRecipients(string campaign)
        {
            HashSet<string> recipients = new HashSet<string>();

            IEnumerable<T> events =eventStore.GetEventByCampaign(campaign);

            foreach (T ev in events)
            {
                recipients.Add(ev.UserEmail);
            }

            return recipients.Count;
        }

        public int GetUniqueUsersForEvent(string campaign,string eventType){
            HashSet<string> users =new HashSet<string>();

            IEnumerable<T> events = eventStore.GetEventByCampaign(campaign);

            foreach (T ev in events)
            {
                if (ev.EventType==eventType)
                {
                    users.Add(ev.UserEmail);
                }
            }

            return users.Count;
        }

        public double CalculateOpenRate(string campaign)
        {
            int recipients = GetRecipients(campaign);

            if (recipients == 0)    return 0;

            int opens = GetUniqueUsersForEvent(campaign, "open");

            return (double)opens / recipients * 100;
        }

        public double CalculateClickThroughRate(string campaign)
        {
            int recipients = GetRecipients(campaign);

            if (recipients == 0)    return 0;

            int clicks =GetUniqueUsersForEvent(campaign, "click");

            return (double)clicks / recipients * 100;
        }

        public double CalculateUnsubscribeRate(string campaign)
        {
            int recipients = GetRecipients(campaign);

            if (recipients == 0)    return 0;

            int unsubscribes =  GetUniqueUsersForEvent(campaign,"unsubscribe");

            return (double)unsubscribes / recipients * 100;
        }

        public List<string> FindClickedWithoutOpening(string campaign)
        {
            HashSet<string> openedUsers =new HashSet<string>();

            HashSet<string> clickedUsers =new HashSet<string>();

            IEnumerable<T> events =eventStore.GetEventByCampaign(campaign);

            foreach (T ev in events)
            {
                if (ev.EventType=="open")
                {
                    openedUsers.Add(ev.UserEmail);
                }

                if (ev.EventType=="click")
                {
                    clickedUsers.Add(ev.UserEmail);
                }
            }

            List<string> anomalies =new List<string>();

            foreach (string user in clickedUsers)
            {
                if (!openedUsers.Contains(user))
                {
                    anomalies.Add(user);
                }
            }

            return anomalies;
        }
    }
}