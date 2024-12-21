public class BasicPlan:Plans
{
    public override string PlanType(string type){
        return type;
    }
    public override int PersonCount(string count){
        return count;
    }
    public override double Price(string price){
        return price;
    }
    public override string Resolution(string resolution){
        return resolution;
    }
    public override string Content(string content){
        return Content;
    }
}