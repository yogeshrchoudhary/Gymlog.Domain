using Gymlog.Domain.Services;
using Gymlog.Domain.Services.Implementation;
using Unity;

namespace Gymlog.Domain
{
    public static class Bootstrapper
    {
        public static void Register(IUnityContainer container)
        {
            container.RegisterType<IExerciseService, ExerciseService>();
        }
    }
}
