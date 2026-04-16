using _32HomeWork;

///HOMEWORK///Create a class that has properties for street address, city, state, and zip code. Then add a FullAddress property that is read-only.
///
AddressModel address = new AddressModel("Chapslee Estate", "Shimla", "Himacahl Pradesh", 171001 , "1234-5678-0987");

address.City = "mohali";
address.City = "chd";

Console.WriteLine(address.Fulladdress);
