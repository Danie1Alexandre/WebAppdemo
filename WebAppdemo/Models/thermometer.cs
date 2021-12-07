namespace WebAppdemo.Models
{
    public class thermometer
    {
        public static string WriteMessage()
        {
            return "Enter temperature in celsius";
        }

        public string WriteMessage(int temperature)
        {
            string outcome;
            
            if (temperature > 37)
                outcome = "You have fever";
            else
                outcome = "You do not have fever";
            
            return outcome;
        }
    }
}
