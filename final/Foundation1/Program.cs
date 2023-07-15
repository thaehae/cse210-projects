using System;

class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello Foundation1 World!");

        Video video1 = new Video("Iam Tongi - Monsters", "Polynesianmama", 210);
        video1._title = "Iam Tongi - Monsters";
        video1._author = "Polynesianmama";
        video1._lengthInSeconds = 210;
        video1.DisplayDetails();
        Comment comment1 = new Comment();
        comment1._namePerson = "Trace80";
       // comment1.AddComment = "Fabulous guy";
        comment1.DisplayComments();
        comment1._namePerson = "Darlen8";
       // comment1.AddComment = "So relaxing";
        comment1.DisplayComments();
        comment1._namePerson = "TongaSamoan";
       // comment1.AddComment = "Absolutely fantastic";
        comment1.DisplayComments();


        Video video2 = new Video("Stan Walker & Don't dream it's over", "Vamdistan", 380);
        video2._title = "Stan Walker & Don't dream it's over";
        video2._author = "Vamdistan";
        video2._lengthInSeconds = 380;
        video2.DisplayDetails();
        Comment comment2 = new Comment();
        comment2._namePerson = "Stanfanforeva";
       // comment2.AddComment = "Stunning vocal";
        comment2.DisplayComments();
        comment2._namePerson = "Vamdistan";
       // comment2.AddComment = "Could listen to him all day";
        comment2.DisplayComments();
        comment2._namePerson = "Whaeamatariki23";
       // comment2.AddComment = "Tino Ataahua";
        comment2.DisplayComments();

        Video video3 = new Video("Putri Ariani sings Loneliness", "TalentquestHQ", 475);
        video3._title = "Putri Ariani sings Loneliness";
        video3._author = "TalentquestHQ";
        video3._lengthInSeconds = 475;
        video3.DisplayDetails();
        Comment comment3 = new Comment();
        comment3._namePerson = "Americasvote115";
       // comment3.AddComment = "Shes the best";
        comment3.DisplayComments();
        comment3._namePerson = "BrandonHH";
       // comment3.AddComment = "Natural talent";
        comment3.DisplayComments();
        comment3._namePerson = "Maddie8402";
       // comment3.AddComment = "Wow I like her a lot";
        comment3.DisplayComments();

        Video video4 = new Video("Iam Tongi @ Eden Festival concert, NZ", "Polynesianmama", 1590);
        video4._title = "Iam Tongi @ Eden Festival concert, NZ";
        video4._author = "Polynesianmama";
        video4._lengthInSeconds = 1590;
        video4.DisplayDetails();
        Comment comment4 = new Comment();
        comment4._namePerson = "Amy666";
       // comment4.AddComment = "The concert was amazing";
        comment4.DisplayComments();
        comment4._namePerson = "Laurenhihi21";
       // comment4.AddComment = "Go Iam!!";
        comment4.DisplayComments();
        comment4._namePerson = "Kailincutepuppy";
       // comment4.AddComment = "Thank you for posting this. I love it";
        comment4.DisplayComments();
        
    }
}