namespace IoC.Web.Models
{
    public interface IDateService
    {
        DateTime GetDateTime {  get; }
    }

    public interface ISingletonDateService :IDateService  {}
    public interface IScopeDateService : IDateService { }
    public interface ITransientDateService : IDateService { }

    //Bunlar default olarak gelen IoC/DI containerdır. Singleton,Scoped,Transient.
}
