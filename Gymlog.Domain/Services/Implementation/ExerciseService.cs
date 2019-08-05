using System.Collections.Generic;
using Gymlog.Domain.Models;

namespace Gymlog.Domain.Services.Implementation
{
    internal class ExerciseService : IExerciseService
    {
        IEnumerable<Exercise> IExerciseService.GetExercises()
        {
            return new Exercise[] 
            {
                new Exercise { Id = 1, Title = "Squats" },
                new Exercise  {Id = 2, Title = "Leg press"},
                new Exercise  {Id = 3, Title = "Calf raises",
                    Asset = new Asset{
                        Id = 1,
                        Type = AssetTypeEnum.Image,
                        Url = "http://www.burnthefatinnercircle.com/members/images/1747.jpg"
                    }
                }
            };
        }
    }
}
