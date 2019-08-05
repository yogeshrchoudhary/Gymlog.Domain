using Gymlog.Domain.Services;
using Gymlog.Domain.Services.Implementation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;
using Unity;

namespace Gymlog.Domain.UnitTests
{
    [TestClass]
    public class ExerciseServiceTests
    {
        private IExerciseService _service;

        public TestContext TestContext { get; set; }

        [TestInitialize]
        public void Initialize()
        {
            var container = new UnityContainer();
            Bootstrapper.Register(container);
            _service = container.Resolve<IExerciseService>();
        }

        [TestMethod]
        public void CreateExerciseServiceTest()
        {
            Assert.IsInstanceOfType(_service, typeof(ExerciseService));
        }

        [TestMethod]
        public void GetExercisesTest()
        {
            var exercises = _service.GetExercises();
            Assert.AreEqual(exercises.Count(), 3);

            foreach (var exercise in exercises)
                TestContext.WriteLine(exercise.Title);
        }
    }
}
