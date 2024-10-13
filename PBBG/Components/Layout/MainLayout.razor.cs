namespace PBBG.Components.Layout;

public partial class MainLayout
{
    private bool isChatOpen { get; set; } = false;

    private List<(string user, string message)> ChatMessages { get; set; } = new List<(string user, string message)>();

    protected override void OnInitialized()
    {
        base.OnInitialized();

        ChatMessages = new List<(string user, string message)>
        {
            ("FarmerJoe", "How's everyone's crops looking this season?"),
            ("GreenThumb", "Mine are doing okay, but my pumpkins aren't growing as fast as I'd hoped."),
            ("SunnyFields", "Same here, I think it's the soil type. Have you tried using fertilizer yet?"),
            ("GreenThumb", "I tried, but I don’t think I used enough. What do you usually use?"),
            ("SunnyFields", "I go with the organic one from the general store. It gives a small boost but keeps the soil healthy long-term."),
            ("FarmerJoe", "That’s a good one! Also, don’t forget to rotate your crops. I always have better yields when I mix up the plots."),
            ("GreenThumb", "Oh, I totally forgot about that! I’ve been planting pumpkins in the same spot for three seasons."),
            ("SunnyFields", "Yeah, that could be why. Pumpkins take a lot out of the soil."),
            ("FarmerJoe", "Try growing something lighter next season, like wheat or carrots. They don’t drain the nutrients as much."),
            ("GreenThumb", "Thanks, I’ll give that a shot next cycle. How about your animals? My chickens are laying eggs like crazy right now."),
            ("SunnyFields", "Haha, same here! I’ve been selling so many eggs at the market."),
            ("FarmerJoe", "My cows are doing well, but I need more space for them. Guess I’ll be building a bigger barn soon!"),
            ("GreenThumb", "That’s awesome! I’m saving up for a sheep pen, wool prices are skyrocketing."),
            ("SunnyFields", "Wool’s always a good investment. Plus, sheep are super low maintenance compared to cows."),
            ("FarmerJoe", "Totally agree. Once you get a pen going, you’ll see a steady profit."),
            ("GreenThumb", "Speaking of animals, does anyone know if goats are worth the investment?"),
            ("FarmLife2020", "Goats are great! They produce milk faster than cows, but the profit margin is a bit smaller."),
            ("SunnyFields", "Yeah, but you can make cheese with goat milk, and that sells for a decent price."),
            ("FarmerJoe", "True, plus goats don’t need as much space as cows, so it’s easier to expand."),
            ("GreenThumb", "Hmm, I might consider it then. Cheese sounds like a good way to diversify."),
            ("SunsetFarm", "Hey all! What’s the best crop to grow for the autumn festival? I’m thinking about entering the contest."),
            ("SunnyFields", "Pumpkins are always a safe bet. People love them for the festival."),
            ("FarmerJoe", "I’ve had good luck with giant sunflowers. They’re easy to grow and stand out in contests."),
            ("FarmLife2020", "Or try corn! It grows fast and you can use it for corn mazes or sell it for good money."),
            ("GreenThumb", "Sunflowers sound fun, I might try that next year!"),
            ("SunsetFarm", "Thanks, I’ll go with pumpkins this time. I want that blue ribbon!"),
            ("FarmerJoe", "Good luck! I won the ribbon last year with a 50-pound pumpkin."),
            ("GreenThumb", "Wow, that’s massive! What did you feed it?"),
            ("FarmerJoe", "Compost, lots of water, and some good ol’ sunshine."),
            ("SunnyFields", "That’s the secret sauce! Nature does most of the work.")
        };
    }

    private async Task OpenChatAsync()
    {
        isChatOpen = !isChatOpen;
    }
}