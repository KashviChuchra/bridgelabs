using System;

namespace EmailCampaign
{
    class Program
    {
        static void Main(string[] args)
        {
            EventStore<EmailEvent> store = new EventStore<EmailEvent>();

            string[] rawEvents =
            {
                "EVENT:open|CAMPAIGN:summer-sale-2026|USER:sarah.jones+promo@mail-example.co.uk|TS:2026-08-11T09:03:00|DEVICE:mobile",
                "EVENT:click|CAMPAIGN:summer-sale-2026|USER:sarah.jones+promo@mail-example.co.uk|TS:2026-08-11T09:05:00|DEVICE:mobile",
                "EVENT:open|CAMPAIGN:summer-sale-2026|USER:john@example.com|TS:2026-08-11T10:03:00|DEVICE:web",
                "EVENT:unsubscribe|CAMPAIGN:summer-sale-2026|USER:mike@example.com|TS:2026-08-11T11:03:00|DEVICE:web",
            };

            foreach (string rawEvent in rawEvents)
            {
                EmailEvent emailEvent = EmailEvent.Parse(rawEvent);
                store.Add(emailEvent);
            }

            EmailCampaignAnalyzer<EmailEvent> analyzer = new EmailCampaignAnalyzer<EmailEvent>(store);

            string campaign1 = "summer-sale-2026";
            Console.WriteLine("Campaign: " + campaign1);
            Console.WriteLine("Recipients: " + analyzer.GetRecipients(campaign1));
            Console.WriteLine("Open Rate: " + analyzer.CalculateOpenRate(campaign1));
            Console.WriteLine("Click Through Rate: " + analyzer.CalculateClickThroughRate(campaign1));
            Console.WriteLine("Unsubscribe Rate: " + analyzer.CalculateUnsubscribeRate(campaign1));

          
            Console.WriteLine("clicked W/0 Opening:");

            foreach (string user in analyzer.FindClickedWithoutOpening(campaign1))
            {
                Console.WriteLine(user);
            }

            
        }
    }
}