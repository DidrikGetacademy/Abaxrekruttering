namespace Abaxrekruttering
{
    internal class Program
    {
        static void Main(string[] args)
        {




            var car1 = new car(200,"NF123456",147,"green",true);
            car1.PrintInformation();


            var car2 = new car(195, "NF654321", 150, "Blue", true);
            car2.PrintInformation();

            var plane = new Plane("LN1234", 1000, 30, 2, 10);
            plane.PrintInformation();

            car1.Run();
            car2.Run();

            var boat = new Boat(30, "ABC123", 100, 500);
            boat.PrintInformation();





            //Printe informasjon om en en bil 1 med reg. nr NF123456, 147kw effekt, maksfart 200km / t, grønn farge av typen lett kjøretøy. 
            //Printe informasjon om en annen bil(bil 2) med reg. nr NF654321, 150kw effekt, maksfart 195km / t, blå farge og av typen lett kjøretøy
            //Sammenlikne de to bilene over for å sjekke om de er det samme kjøretøyet
            //Printe informasjon om et fly med kjennetegn LN1234, 1000kw effekt, 30m vingespenn, 2tonn lasteevne, 10 tonn egenvekt I flyklasse jetfly
            //Konsollprogrammet skal be flyet om å fly og printe dette i konsollet.
            //Konsollprogrammet skal be bil 1 om å kjøre og printe dette I konsollet
            //Printe informasjon om en båt med kjennetegn ABC123, 100kw effekt, maksfart på 30knop, 500kg bruttotonnasje.








        }
    }
}

