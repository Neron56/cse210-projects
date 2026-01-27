using System;

class Program
{
    static void Main(string[] args)
    {
        Video video1 = new Video("10 Products you'll love!","Andy Reviews", 970);
        Video video2 = new Video("Try out this new sick gadget","Randy Savage", 533);
        Video video3 = new Video("When will this product break?!?!?!(You wouldn't believe what it takes!)","ViralBigBoomBros", 545);
        Video video4 = new Video("Lets see what this is all about(Product Review)","Labs Breakdown", 1986);
        Comment comment1 = new Comment("DaveReviews","I definitely need to try some of these out!");
        Comment comment2 = new Comment("C4TLUVR","My cats would love number 4!");
        Comment comment3 = new Comment("TonyLazuto","Very Cool Video! You always have great content!");
        Comment comment4 = new Comment("MollyMyGolly","Woah, didn't realize I needed one of those until now.");
        Comment comment5 = new Comment("StinkySteven","You say it's pretty sick, but I say it's pretty stinky");
        Comment comment6 = new Comment("HandbagMaster","This is truly a quality product, I already own 5!");
        Comment comment7 = new Comment("FrequentEater","First!");
        Comment comment8 = new Comment("TotallyAGuy32","This is a relevant comment!");
        Comment comment9 = new Comment("S0nOfADun","You should keep making more videos like this.");
        Comment comment10 = new Comment("MildManneredMike","What a thoughtful video, way to help out small businesses!");
        Comment comment11 = new Comment("StinkySteven","Didn't think i'd be back ey? What a smell to come wafting in again.");
        Comment comment12 = new Comment("Indistinguished_Laundry_Basket","Everytime I watch your Videos, I always come away with something new!");

        video1.AddComments(comment1);
        video1.AddComments(comment2);
        video1.AddComments(comment3);
        video1.ShowVideoInformation();
        Console.WriteLine("");

        video2.AddComments(comment4);
        video2.AddComments(comment5);
        video2.AddComments(comment6);
        video2.ShowVideoInformation();
        Console.WriteLine("");

        video3.AddComments(comment7);
        video3.AddComments(comment8);
        video3.AddComments(comment9);
        video3.ShowVideoInformation();
        Console.WriteLine("");

        video4.AddComments(comment10);
        video4.AddComments(comment11);
        video4.AddComments(comment12);
        video4.ShowVideoInformation();
    }
}