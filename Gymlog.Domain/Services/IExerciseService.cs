using Gymlog.Domain.Models;
using System.Collections.Generic;

namespace Gymlog.Domain.Services
{
    public interface IExerciseService
    {
        IEnumerable<Exercise> GetExercises();
    }
}
