DateTime today = DateTime.Today;
string date = " ";
do
{
    Console.WriteLine("Enter the date or type \"exit\" ");
    date = Console.ReadLine();
    DateTime parsed;
    TimeSpan ts;

    if ( date == "exit")
    {
        break;
    }
    {
        
    }
    if (DateTime.TryParse(date, out parsed))
    {
        if(parsed < today)
        {
            ts = today - parsed;
            Console.WriteLine($"That day went by {ts.Days} days" );
        }else if(parsed > today)
        {
            ts = parsed - today;
            Console.WriteLine( $"This day will be in {ts.Days} days");
        }
        else
        {
            Console.WriteLine( $"This day is today");
        }

    }
    else
    {
        Console.WriteLine($"{date, -10}This is not a valid day: Try again");
    }

} while (date != "exit");