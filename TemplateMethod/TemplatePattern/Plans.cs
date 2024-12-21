public abstract class Plans{
    public void Plans(){
        PlanType(string.Empty);
        PersonCount(0);
        Price(0);
        Resolution(string.Empty);
        Content(string.Empty);
    }
    public abstract string PlanType(string type);
    public abstract int PersonCount(string count);
    public abstract double Price(string price);
    public abstract string Resolution(string resolution);
    public abstract string Content(string content);
}