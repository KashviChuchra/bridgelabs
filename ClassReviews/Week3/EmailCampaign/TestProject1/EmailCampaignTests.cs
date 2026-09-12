using System;
using NUnit.Framework;

namespace EmailCampaign.Tests
{
    public class EmailCampaignTests
    {
        [Test]
        public void Parse()
        {
            EmailEvent e = EmailEvent.Parse("EVENT:open|CAMPAIGN:test|USER:a@example.com|TS:2026-08-11T09:03:00|DEVICE:web");
            Assert.That(e.EventType, Is.EqualTo("open"));
            Assert.That(e.Campaign, Is.EqualTo("test"));
            Assert.That(e.UserEmail, Is.EqualTo("a@example.com"));
        }

        [Test]
        public void OpenRate()
        {
            EventStore<EmailEvent> store = new EventStore<EmailEvent>();
            store.Add(EmailEvent.Parse("EVENT:open|CAMPAIGN:test|USER:a@example.com|TS:2026-08-11T09:03:00|DEVICE:web"));
            store.Add(EmailEvent.Parse("EVENT:open|CAMPAIGN:test|USER:b@example.com|TS:2026-08-11T10:03:00|DEVICE:web"));
            EmailCampaignAnalyzer<EmailEvent> analyzer = new EmailCampaignAnalyzer<EmailEvent>(store);
            Assert.That(analyzer.CalculateOpenRate("test"), Is.EqualTo(100));
        }

        [Test]
        public void ClickRate()
        {
            EventStore<EmailEvent> store = new EventStore<EmailEvent>();
            store.Add(EmailEvent.Parse("EVENT:click|CAMPAIGN:test|USER:a@example.com|TS:2026-08-11T09:03:00|DEVICE:web"));
            store.Add(EmailEvent.Parse("EVENT:open|CAMPAIGN:test|USER:b@example.com|TS:2026-08-11T10:03:00|DEVICE:web"));
            EmailCampaignAnalyzer<EmailEvent> analyzer = new EmailCampaignAnalyzer<EmailEvent>(store);
            Assert.That(analyzer.CalculateClickThroughRate("test"), Is.EqualTo(50));
        }

        [Test]
        public void UnsubRate()
        {
            EventStore<EmailEvent> store = new EventStore<EmailEvent>();
            store.Add(EmailEvent.Parse("EVENT:unsubscribe|CAMPAIGN:test|USER:a@example.com|TS:2026-08-11T09:03:00|DEVICE:web"));
            store.Add(EmailEvent.Parse("EVENT:open|CAMPAIGN:test|USER:b@example.com|TS:2026-08-11T10:03:00|DEVICE:web"));
            EmailCampaignAnalyzer<EmailEvent> analyzer = new EmailCampaignAnalyzer<EmailEvent>(store);
            Assert.That(analyzer.CalculateUnsubscribeRate("test"), Is.EqualTo(50));
        }

        [Test]
        public void NoOpen()
        {
            EventStore<EmailEvent> store = new EventStore<EmailEvent>();
            store.Add(EmailEvent.Parse("EVENT:click|CAMPAIGN:test|USER:a@example.com|TS:2026-08-11T09:03:00|DEVICE:web"));
            EmailCampaignAnalyzer<EmailEvent> analyzer = new EmailCampaignAnalyzer<EmailEvent>(store);
            Assert.That(analyzer.FindClickedWithoutOpening("test").Contains("a@example.com"), Is.True);
        }

        [Test]
        public void AfterOpen()
        {
            EventStore<EmailEvent> store = new EventStore<EmailEvent>();
            store.Add(EmailEvent.Parse("EVENT:open|CAMPAIGN:test|USER:a@example.com|TS:2026-08-11T09:03:00|DEVICE:web"));
            store.Add(EmailEvent.Parse("EVENT:click|CAMPAIGN:test|USER:a@example.com|TS:2026-08-11T09:05:00|DEVICE:web"));
            EmailCampaignAnalyzer<EmailEvent> analyzer = new EmailCampaignAnalyzer<EmailEvent>(store);
            Assert.That(analyzer.FindClickedWithoutOpening("test").Contains("a@example.com"), Is.False);
        }

        [Test]
        public void Campaigns()
        {
            EventStore<EmailEvent> store = new EventStore<EmailEvent>();
            store.Add(EmailEvent.Parse("EVENT:click|CAMPAIGN:test1|USER:a@example.com|TS:2026-08-11T09:03:00|DEVICE:web"));
            store.Add(EmailEvent.Parse("EVENT:open|CAMPAIGN:test2|USER:a@example.com|TS:2026-08-11T09:05:00|DEVICE:web"));
            EmailCampaignAnalyzer<EmailEvent> analyzer = new EmailCampaignAnalyzer<EmailEvent>(store);
            Assert.That(analyzer.FindClickedWithoutOpening("test1").Contains("a@example.com"), Is.True);
        }
    }
}