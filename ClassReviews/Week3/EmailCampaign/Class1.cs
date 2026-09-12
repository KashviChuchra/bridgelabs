using System;
public class EmailCampaign
{
	
		public string Receiptients { get; set; }
		public string Campaigns { get; set; }
		public int Clicks { get; set; }
		public int Unsubscribers { get; set; }
		public int Opens { get; set; }
		public double OpenRate { get; set; }
		public double ClickThroughRate { get; set; }
        public double UnsubscribersRate { get; set; }
}

public class EmailCampaignAnalyzer<T> where T : EmailEvent
{
	private readonly EventStore<T>;
	public EmailCampaignAnalyzer(T eventstore)
	{
		EventStore = eventstore;
	}
	public EmailCampaign AnalyzeCampaigns()
	{
		var events_campaign = EventStore.getByCampaign();
		var events_user = EventStore.getByUser();

		if (events_campaign != null)
		{
			if (events_campaign.EventType.equals("open"))
			{
				Opens++;
			}
			else if (events_campaign.EventType.equals("unsubscribe"))
			{
				Unsubscribers++;
			}
			else if (events_campaign.EventType.equals("click"))
			{
				Clicks++;
			}
			else if (events_campaign.EventType.equals("bounce"))
			{

			}
			CalculateOpenRate();
			CalculateClickThroughRate();
			CalculateUnsubscribersRate();
        }

	}

	public double CalculateOpenRate()
	{
		OpenRate = Opens / Receipents * 100;
		return OpenRate;
	}

	public double CalculateClickThroughRate()
	{
        ClickThroughRate = Clicks / Receipents * 100;
		return ClickThroughRate;
    }
	public double CalculateUnsubscribersRate()
	{
        UnsubscribersRate = Unsubscribers / Receipents * 100;
		return UnsubscribersRate;
    }
}
