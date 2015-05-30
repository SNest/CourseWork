using Ninject.Modules;
using ToDo.DAL.Repositories.Abstract;
using ToDo.DAL.Repositories.Concrete;

namespace ToDo.BLL.Infrastracture
{
    class Bindings : NinjectModule
    {
        public override void Load()
        {
            Bind<ICaseRepository>().To<EFCaseRepository>();
            Bind<IEventRepository>().To<EFEventRepository>();
            Bind<INoteRepository>().To<EFNoteRepository>();
            Bind<IUserRepository>().To<EFUserRepository>();
        }
    }
}
