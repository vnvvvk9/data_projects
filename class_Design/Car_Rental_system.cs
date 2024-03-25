public class car{
    string carid{get;set;}
    string make {get; set}
    string model{get;set;}
    string year{get;set;}
    string isAvailable{get;set;}
    decimal pricePerDay{get;set;}

}

public class custeomer{
    string naame{set;set;}
    string email{get;set;}
    string phone{get;set;}
    Address address {get;set;}
    DriversLicence {get;set;}
}

class REntal{
    string rentailid{get;set;}
    string startdata{get;set;}
    string enddate{get;set;}
    Car RendtedCar{get;set;}
    string Deiscmal TotalCost{get;set;}
    string customer {get;set;}
}


class CarREntalSystem{
    private List<car> cars;
    private List<custeomer> custoemrs;
    private List<REntal> rentals;

    public carRentlaSYstem(){

    }

    public bool RentCar(custeomer sut,car car, DateTime stat, Datetime end){
    }

    public void ReturnCar(REntal rental){
        
    }


}
