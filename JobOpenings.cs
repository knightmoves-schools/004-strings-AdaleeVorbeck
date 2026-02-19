using System.Reflection.Metadata.Ecma335;

namespace knightmoves;
public class JobOpenings
{   
    // Add your code here
    public string FirstName = "Katie";
    public string JobTitle = "Botanic Analyst";
    public string City = "Astoria, Oregon";
    public string PrintOpening()
    {
        //Add your code here
        string Job = $@"Dear {FirstName},
Thank you for considering my applicant for the {JobTitle} position.
I am looking forward to the beautiful scenery of {City}. 
I hope that we can do great things together in the future. 

Sincerely,
Random Name :)";
        return Job;
    }


}

/*should define a public class-level string variable named FirstName
should define a public class-level string variable named JobTitle
should define a public class-level string variable named City
should return a string from the PrintOpening method that contains FirstName, JobTitle, City, and a new line*/
