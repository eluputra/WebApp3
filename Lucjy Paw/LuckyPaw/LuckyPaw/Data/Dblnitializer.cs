using LuckyPaw.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LuckyPaw.Data
{
    public static class DbInitializer
    {
        public static void Initialize(LuckyPawContext context)
        {
            context.Database.EnsureCreated();

            // Look for any prices.
            if (context.PricingPuppyModel.Any())
            {
                return;   // DB has been seeded
            }
            
            var pricesPuppyArr = new PricingPuppyModel[]
            {
                new PricingPuppyModel { PricePuppyDesc = "Test1",   PricePuppy = 100,
                    PricePuppyImageUrl = "https:\\www.google.com", PuppyQty = 1 },
                new PricingPuppyModel { PricePuppyDesc = "Test2",   PricePuppy = 200,
                    PricePuppyImageUrl = "https:\\www.google.com", PuppyQty = 1  },
                new PricingPuppyModel { PricePuppyDesc = "Test3",   PricePuppy = 300,
                    PricePuppyImageUrl = "https:\\www.google.com", PuppyQty = 1  },
                new PricingPuppyModel { PricePuppyDesc = "Test4",   PricePuppy = 400,
                    PricePuppyImageUrl = "https:\\www.google.com", PuppyQty = 1  },
                new PricingPuppyModel { PricePuppyDesc = "Test5",   PricePuppy = 500,
                    PricePuppyImageUrl = "https:\\www.google.com", PuppyQty = 1  },
                new PricingPuppyModel { PricePuppyDesc = "Test6",   PricePuppy = 600,
                    PricePuppyImageUrl = "https:\\www.google.com", PuppyQty = 1  },
                new PricingPuppyModel { PricePuppyDesc = "Test7",   PricePuppy = 700,
                    PricePuppyImageUrl = "https:\\www.google.com", PuppyQty = 1  },
                new PricingPuppyModel { PricePuppyDesc = "Test8",   PricePuppy = 800,
                    PricePuppyImageUrl = "https:\\www.google.com", PuppyQty = 1  }
            };

            foreach (PricingPuppyModel pPuppyModel in pricesPuppyArr)
            {
                context.PricingPuppyModel.Add(pPuppyModel);
            }

            context.SaveChanges();
            
            // TrainingId cannot be the same because trainingId is the key, so
            // if you make trainingId the same, there would be a database seed error
            // For the TrainingId, you cannot set values for this column because it is a primary key, it auto increments
            var trainingArr = new TrainingDogModel[]
            {
                new TrainingDogModel { DogName = "Mark",
                    TrainerId = "Train1", GraduationDate = DateTime.Parse("03-11-1995"),
                    TrainingType = "Manual" },
                new TrainingDogModel { DogName = "Andy",
                    TrainerId = "Train1", GraduationDate = DateTime.Parse("03-11-1995"),
                    TrainingType = "Manual" },
                new TrainingDogModel { DogName = "William",
                    TrainerId = "Train1", GraduationDate = DateTime.Parse("03-11-1995"),
                    TrainingType = "Manual" },
                new TrainingDogModel { DogName = "Michael",
                    TrainerId = "Train2", GraduationDate = DateTime.Parse("03-11-1995"),
                    TrainingType = "Manual" },
                new TrainingDogModel { DogName = "Ronnie",
                    TrainerId = "Train2", GraduationDate = DateTime.Parse("03-11-1995"),
                    TrainingType = "Manual" },
                new TrainingDogModel { DogName = "Getrude",
                    TrainerId = "Train2", GraduationDate = DateTime.Parse("03-11-1995"),
                    TrainingType = "Manual" },
                new TrainingDogModel { DogName = "Sen",
                    TrainerId = "Train3", GraduationDate = DateTime.Parse("03-11-1995"),
                    TrainingType = "Manual" },
                new TrainingDogModel { DogName = "Ten",
                    TrainerId = "Train3", GraduationDate = DateTime.Parse("03-11-1995"),
                    TrainingType = "Manual" }
            };

            foreach (TrainingDogModel trainingDog in trainingArr)
            {
                context.TrainingDogModel.Add(trainingDog);
            }

            context.SaveChanges();

            var trainingServicesPriceArr = new TrainingServicesPriceModel[]
            {
                new TrainingServicesPriceModel { TrainingName = "Train1",
                    PriceTraining = 3000, TrainingDesc = "Train1Desc", TrainingQty=10
                    },
                new TrainingServicesPriceModel { TrainingName = "Train2",
                    PriceTraining = 4000, TrainingDesc = "Train2Desc", TrainingQty=20
                    },
                new TrainingServicesPriceModel { TrainingName = "Train3",
                    PriceTraining = 5000, TrainingDesc = "Train3Desc", TrainingQty=30
                    },
                new TrainingServicesPriceModel { TrainingName = "Train4",
                    PriceTraining = 6000, TrainingDesc = "Train4Desc", TrainingQty=40
                    },
                new TrainingServicesPriceModel { TrainingName = "Train5",
                    PriceTraining = 7000, TrainingDesc = "Train5Desc", TrainingQty=50
                    },
                new TrainingServicesPriceModel { TrainingName = "Train6",
                    PriceTraining = 8000, TrainingDesc = "Train6Desc", TrainingQty=60
                    },
                new TrainingServicesPriceModel { TrainingName = "Train7",
                    PriceTraining = 9000, TrainingDesc = "Train7Desc", TrainingQty=70
                    },
                new TrainingServicesPriceModel { TrainingName = "Train8",
                    PriceTraining = 10000, TrainingDesc = "Train8Desc", TrainingQty=100
                    }
            };

            foreach (TrainingServicesPriceModel trainingServicesPrice in trainingServicesPriceArr)
            {
                context.TrainingServicesPriceModel.Add(trainingServicesPrice);
            }

            context.SaveChanges();

            var loginArr = new LoginModel[]
            {
                new LoginModel { Username = "Train1",
                    Password = "abc"
                    },
                new LoginModel {  Username = "Train2",
                    Password = "abcd"
                    },
                new LoginModel {  Username = "Train3",
                    Password = "abcde"
                    },
                new LoginModel {  Username = "Train4",
                    Password = "abcdef"
                    },
                new LoginModel {  Username = "Train5",
                    Password = "abcdefg"
                    },
                new LoginModel { Username = "Train6",
                    Password = "abcdefgh"
                    },
                new LoginModel {  Username = "Train7",
                    Password = "abcdefghi"
                    },
                new LoginModel {  Username = "Train8",
                    Password = "abcdefghil"
                    }
            };

            foreach (LoginModel login in loginArr)
            {
                context.LoginModel.Add(login);
            }

            context.SaveChanges();

            var registrationArr = new RegistrationModel[]
           {
                new RegistrationModel { FirstName = "Jesus",
                    LastName = "Christ", UserName = "JesusChrist",
                    Password = "abc", Email = "Jesus@gmail.com",
                    PhoneNumber = "Call Heaven", Address = "Heavenly Kingdom",
                    City = "City of David", State = "Heaven", ZipCode = "77777",
                    Role = "User"
                    },
                new RegistrationModel { FirstName = "Jesus",
                    LastName = "Christ", UserName = "JesusChrist",
                    Password = "abc", Email = "Jesus@gmail.com",
                    PhoneNumber = "Call Heaven", Address = "Heavenly Kingdom",
                    City = "City of David", State = "Heaven", ZipCode = "77777",
                    Role = "User"
                    },
                new RegistrationModel { FirstName = "Jesus",
                    LastName = "Christ", UserName = "JesusChrist",
                    Password = "abc", Email = "Jesus@gmail.com",
                    PhoneNumber = "Call Heaven", Address = "Heavenly Kingdom",
                    City = "City of David", State = "Heaven", ZipCode = "77777",
                    Role = "User"
                    },
                new RegistrationModel { FirstName = "Jesus",
                    LastName = "Christ", UserName = "JesusChrist",
                    Password = "abc", Email = "Jesus@gmail.com",
                    PhoneNumber = "Call Heaven", Address = "Heavenly Kingdom",
                    City = "City of David", State = "Heaven", ZipCode = "77777",
                    Role = "User"
                    },
                new RegistrationModel { FirstName = "Jesus",
                    LastName = "Christ", UserName = "JesusChrist",
                    Password = "abc", Email = "Jesus@gmail.com",
                    PhoneNumber = "Call Heaven", Address = "Heavenly Kingdom",
                    City = "City of David", State = "Heaven", ZipCode = "77777",
                    Role = "User"
                    },
               new RegistrationModel { FirstName = "Jesus",
                    LastName = "Christ", UserName = "JesusChrist",
                    Password = "abc", Email = "Jesus@gmail.com",
                    PhoneNumber = "Call Heaven", Address = "Heavenly Kingdom",
                    City = "City of David", State = "Heaven", ZipCode = "77777",
                    Role = "User"
                    },
                new RegistrationModel { FirstName = "Jesus",
                    LastName = "Christ", UserName = "JesusChrist",
                    Password = "abc", Email = "Jesus@gmail.com",
                    PhoneNumber = "Call Heaven", Address = "Heavenly Kingdom",
                    City = "City of David", State = "Heaven", ZipCode = "77777",
                    Role = "Manager"
                    },
                new RegistrationModel { FirstName = "Jesus",
                    LastName = "Christ", UserName = "JesusChrist",
                    Password = "abc", Email = "Jesus@gmail.com",
                    PhoneNumber = "Call Heaven", Address = "Heavenly Kingdom",
                    City = "City of David", State = "Heaven", ZipCode = "77777",
                    Role = "Admin"
                    }
           };

            foreach (RegistrationModel registration in registrationArr)
            {
                context.RegistrationModel.Add(registration);
            }

            context.SaveChanges();

            var trainersArr = new TrainersModel[]
            {
                new TrainersModel { TrainerId = "Train1",
                    TrainerName = "Anthony", TrainerArea = "microsoft",
                    DogNumber = 5, DogName = "Mark"
                    },
                 new TrainersModel { TrainerId = "Train2",
                    TrainerName = "Evan", TrainerArea = "microsoft",
                    DogNumber = 5, DogName = "Mark"
                    },
                new TrainersModel { TrainerId = "Train3",
                    TrainerName = "William", TrainerArea = "microsoft",
                    DogNumber = 5, DogName = "Mark"
                    },
                 new TrainersModel { TrainerId = "Train4",
                    TrainerName = "Robert", TrainerArea = "microsoft",
                    DogNumber = 5, DogName = "Mark"
                    },
                 new TrainersModel { TrainerId = "Train5",
                    TrainerName = "Andrew", TrainerArea = "microsoft",
                    DogNumber = 5, DogName = "Mark"
                    },
                 new TrainersModel { TrainerId = "Train6",
                    TrainerName = "Tim", TrainerArea = "microsoft",
                    DogNumber = 5, DogName = "Mark"
                    },
                 new TrainersModel { TrainerId = "Train7",
                    TrainerName = "Junior", TrainerArea = "microsoft",
                    DogNumber = 5, DogName = "Mark"
                    },
                 new TrainersModel { TrainerId = "Train8",
                    TrainerName = "Sally", TrainerArea = "microsoft",
                    DogNumber = 5, DogName = "Mark"
                    }
            };

            foreach (TrainersModel trainer in trainersArr)
            {
                context.TrainersModel.Add(trainer);
            }

            context.SaveChanges();
        }
    }
}

