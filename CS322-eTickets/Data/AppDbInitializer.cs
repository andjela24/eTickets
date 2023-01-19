using CS322_eTickets.Data.Enums;
using CS322_eTickets.Data.Static;
using CS322_eTickets.Models;
using Microsoft.AspNetCore.Identity;

namespace CS322_eTickets.Data
{
	public class AppDbInitializer
	{
		public static void Seed(IApplicationBuilder applicationBuilder)
		{
			using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
			{
				var context = serviceScope.ServiceProvider.GetService<AppDbContext>();

				context.Database.EnsureCreated();

				//Cinema
				if (!context.Cinemas.Any())
				{
					context.Cinemas.AddRange(new List<Cinema>()
					{
						new Cinema()
						{
							Name = "Cinema 1",
							Logo = "https://ibb.co/GJtYsL6",
							Description = "This is the description of the first cinema"
						},
						new Cinema()
						{
							Name = "Cinema 2",
							Logo = "https://ibb.co/jwzGF2q",
							Description = "This is the description of the first cinema"
						},
						new Cinema()
						{
							Name = "Cinema 3",
							Logo = "https://ibb.co/mChk2td",
							Description = "This is the description of the first cinema"
						},
						new Cinema()
						{
							Name = "Cinema 4",
							Logo = "https://ibb.co/FzYjX8B",
							Description = "This is the description of the first cinema"
						},
						new Cinema()
						{
							Name = "Cinema 5",
							Logo = "https://ibb.co/thnyBYR",
							Description = "This is the description of the first cinema"
						},
					});
					context.SaveChanges();
				}
				//Actors
				if (!context.Actors.Any())
				{
					context.Actors.AddRange(new List<Actor>()
					{
						new Actor()
						{
							FullName = "Zoran Cvijanovic",
							Bio = "This is the Bio of the actor Zoran Cvijanovic",
							ProfilePictureURL = "https://ibb.co/8jNLfPb"

                        },
						new Actor()
						{
							FullName = "Vuk Kostic",
							Bio = "This is the Bio of the actor Vuk Kostic",
							ProfilePictureURL = "https://ibb.co/8jNLfPb"
                        },
						new Actor()
						{
							FullName = "Tihomir Stanic",
							Bio = "This is the Bio of the actor Tihomir Stanic",
							ProfilePictureURL = "https://ibb.co/9rc7kJp"
                        },
						new Actor()
						{
							FullName = "Tanja Boskovic",
							Bio = "This is the Bio of the actor Tanja Boskovic",
							ProfilePictureURL = "https://ibb.co/5hxZSrT"
                        },
						new Actor()
						{
							FullName = "Srdjan Todorovic",
							Bio = "This is the Bio of the actor Srdjan Todorovic",
							ProfilePictureURL = "https://ibb.co/p3Yrd13"
                        },
                        new Actor()
                        {
                            FullName = "Sergej Trifunovic",
                            Bio = "This is the Bio of the actor Sergej Trifunovic",
                            ProfilePictureURL = "https://ibb.co/kKQ1wqS"
                        },

                        new Actor()
                        {
                            FullName = "Nikola Rakocevic",
                            Bio = "This is the Bio of the actor Nikola Rakocevic",
                            ProfilePictureURL = "https://ibb.co/nbkL8ry"
                        },
                        new Actor()
                        {
                            FullName = "Nikola Djuricko",
                            Bio = "This is the Bio of the actor Nikola Djuricko",
                            ProfilePictureURL = "https://ibb.co/xs3h1cB"
                        },
                        new Actor()
                        {
                            FullName = "Nenad Jezdic",
                            Bio = "This is the Bio of the actor Nenad Jezdic",
                            ProfilePictureURL = "https://ibb.co/85ZhB4Z"
                        },
                        new Actor()
                        {
                            FullName = "Nebojsa Glogovac",
                            Bio = "This is the Bio of the actor Nebojsa Glogovac",
                            ProfilePictureURL = "https://ibb.co/fpKzFNL"
                        },
                        new Actor()
                        {
                            FullName = "Mima Karadzic",
                            Bio = "This is the Bio of the actor Mima Karadzic",
                            ProfilePictureURL = "https://ibb.co/WkHK7qp"
                        },
                        new Actor()
                        {
                            FullName = "Natasa Tapuskovic",
                            Bio = "This is the Bio of the actor Natasa Tapuskovic",
                            ProfilePictureURL = "https://ibb.co/BPbnjNn"
                        },
                        new Actor()
                        {
                            FullName = "Milos Bikovic",
                            Bio = "This is the Bio of the actor Milos Bikovic",
                            ProfilePictureURL = "https://ibb.co/KF03B6d"
                        },
                        new Actor()
                        {
                            FullName = "Milena Radulovic",
                            Bio = "This is the Bio of the actor Milena Radulovic",
                            ProfilePictureURL = "https://ibb.co/cJWmmvF"
                        },
                        new Actor()
                        {
                            FullName = "Lazar Ristovski",
                            Bio = "This is the Bio of the actor Lazar Ristovski",
                            ProfilePictureURL = "https://ibb.co/4tRmPw4"
                        },
                        new Actor()
                        {
                            FullName = "Katarina Radivojevic",
                            Bio = "This is the Bio of the actor Katarina Radivojevic",
                            ProfilePictureURL = "https://ibb.co/C6yMszw"
                        },
                        new Actor()
                        {
                            FullName = "Gordan Kicic",
                            Bio = "This is the Bio of the actor Gordan Kicic",
                            ProfilePictureURL = "https://ibb.co/P1LzKsc"
                        },
                        new Actor()
                        {
                            FullName = "Dubravka Mijatovic",
                            Bio = "This is the Bio of the actor Dubravka Mijatovic",
                            ProfilePictureURL = "https://ibb.co/nsQ67DY"
                        },
                        new Actor()
                        {
                            FullName = "Goran Radakovic",
                            Bio = "This is the Bio of the actor Goran Radakovic",
                            ProfilePictureURL = "https://ibb.co/8NJVGVK"
                        },
                        new Actor()
                        {
                            FullName = "Dragan Petrovic Pele",
                            Bio = "This is the Bio of the actor Dragan Petrovic Pele",
                            ProfilePictureURL = "https://ibb.co/w4QzP52"
                        },
                        new Actor()
                        {
                            FullName = "Dragan Micanovic",
                            Bio = "This is the Bio of the actor Dragan Micanovic",
                            ProfilePictureURL = "https://ibb.co/7zhKw6G"
                        },
                        new Actor()
                        {
                            FullName = "Dragan Jovanovic",
                            Bio = "This is the Bio of the actor Dragan Jovanovic",
                            ProfilePictureURL = "https://ibb.co/Rvf5Y5M"
                        },
                        new Actor()
                        {
                            FullName = "Dragan Bjelogrlic",
                            Bio = "This is the Bio of the actor Dragan Bjelogrlic",
                            ProfilePictureURL = "https://ibb.co/C8csHXd"
                        },
                        new Actor()
                        {
                            FullName = "Brankica Sebastijanovic",
                            Bio = "This is the Bio of the actor Brankica Sebastijanovic",
                            ProfilePictureURL = "https://ibb.co/kXVVp8C"
                        },
                        new Actor()
                        {
                            FullName = "Branka Katic",
                            Bio = "This is the Bio of the second actor",
                            ProfilePictureURL = "https://ibb.co/nRqx3rR"
                        },
                        new Actor()
                        {
                            FullName = "Boris Milivojevic",
                            Bio = "This is the Bio of the second actor",
                            ProfilePictureURL = "https://ibb.co/c2HDBf8"
                        },
                        new Actor()
                        {
                            FullName = "Andrija Milosevic",
                            Bio = "This is the Bio of the second actor",
                            ProfilePictureURL = "https://ibb.co/C1dsFGz"
                        },
                        new Actor()
                        {
                            FullName = "Andjela Jovanovic",
                            Bio = "This is the Bio of the second actor",
                            ProfilePictureURL = "https://ibb.co/McBzcr8"
                        },
                        new Actor()
                        {
                            FullName = "Aleksandra Balmazovic",
                            Bio = "This is the Bio of the second actor",
                            ProfilePictureURL = "https://ibb.co/3BDW36M"
                        },
                        new Actor()
                        {
                            FullName = "Aleksandar Radojcic",
                            Bio = "This is the Bio of the second actor",
                            ProfilePictureURL = "https://ibb.co/6YxHtBD"
                        },
                        new Actor()
                        {
                            FullName = "Aleksandar Bercek",
                            Bio = "This is the Bio of the second actor",
                            ProfilePictureURL = "https://ibb.co/Q88YPdB"
                        }

                    });
					context.SaveChanges();
				}
				//Producers
				if (!context.Producers.Any())
				{
					context.Producers.AddRange(new List<Producer>()
					{
						new Producer()
						{
							FullName = "Predrag Velinovic",
							Bio = "This is the Bio of the producer Predrag Velinovic",
							ProfilePictureURL = "https://ibb.co/1JGRjQD"

                        },
						new Producer()
						{
							FullName = "Miroslav Terzic",
							Bio = "This is the Bio of the producer Miroslav Terzic",
							ProfilePictureURL = "https://ibb.co/7RTdrKT"
                        },
						new Producer()
						{
							FullName = "Radivoje Andric",
							Bio = "This is the Bio of the producer Radivoje Andric",
							ProfilePictureURL = "https://ibb.co/rkF26dc"
                        },
						new Producer()
						{
							FullName = "Srdjan Koljevic",
							Bio = "This is the Bio of the second actor",
							ProfilePictureURL = "https://ibb.co/WnFwxrb"
                        },
						new Producer()
						{
							FullName = "Zdravko Sotra",
							Bio = "This is the Bio of the producer Srdjan Koljevic",
							ProfilePictureURL = "https://ibb.co/ss8Jgb2"
                        },
                        new Producer()
                        {
                            FullName = "Milorad Milinkovic",
                            Bio = "This is the Bio of the producer Milorad Milinkovic",
                            ProfilePictureURL = "https://ibb.co/qgBX0rb"
                        },
                        new Producer()
                        {
                            FullName = "Dejan Zecevic",
                            Bio = "This is the Bio of the producer Dejan Zecevic",
                            ProfilePictureURL = "https://ibb.co/3y8mbmD"
                        },
                        new Producer()
                        {
                            FullName = "Andrey Volgin",
                            Bio = "This is the Bio of the producer Andrey Volgin",
                            ProfilePictureURL = "https://ibb.co/546bCF4"
                        },
                        new Producer()
                        {
                            FullName = "Miroslav Stamatov",
                            Bio = "This is the Bio of the producer Miroslav Stamatov",
                            ProfilePictureURL = "https://ibb.co/sRbV663"
                        },
                        new Producer()
                        {
                            FullName = "Goran Markovic",
                            Bio = "This is the Bio of the producer Goran Markovic",
                            ProfilePictureURL = "https://ibb.co/gMJxVfs"
                        },
                        new Producer()
                        {
                            FullName = "Dragan Marinkovic",
                            Bio = "This is the Bio of the producer Dragan Marinkovic",
                            ProfilePictureURL = "https://ibb.co/FbbyCX7"
                        },
                        new Producer()
                        {
                            FullName = "Ivan Krstovic",
                            Bio = "This is the Bio of the producer Ivan Krstovic",
                            ProfilePictureURL = "https://ibb.co/G3bz5gX"
                        }

                    });
					context.SaveChanges();
				}
				//Movies
				if (!context.Movies.Any())
				{
					context.Movies.AddRange(new List<Movie>()
					{
						new Movie()
						{
							Name = "Volim te najvise na svetu",
							Description = "This is the movie description",
							Price = 9.50,
							ImageURL = "https://ibb.co/RNjV6DW",
							StartDate = DateTime.Now.AddDays(-10),
							EndDate = DateTime.Now.AddDays(10),
							CinemaId = 3,
							ProducerId = 1,
							MovieCategory = MovieCategory.Comedy
						},
						new Movie()
						{
							Name = "Ustanicka ulica",
							Description = "This is the movie description",
							Price = 9.50,
							ImageURL = "https://ibb.co/QN2VzsV",
							StartDate = DateTime.Now,
							EndDate = DateTime.Now.AddDays(3),
							CinemaId = 1,
							ProducerId = 2,
							MovieCategory = MovieCategory.Action
						},
						new Movie()
						{
							Name = "3 Palme za 2 bitange i ribicu",
							Description = "This is the movie description",
							Price = 11.50,
							ImageURL = "https://ibb.co/Qk6wyNx",
							StartDate = DateTime.Now,
							EndDate = DateTime.Now.AddDays(7),
							CinemaId = 4,
							ProducerId = 3,
							MovieCategory = MovieCategory.Comedy
						},
						new Movie()
						{
							Name = "Sivi kamion crvene boje",
							Description = "This is the movie description",
							Price = 39.50,
							ImageURL = "https://ibb.co/HNwWR9Y",
							StartDate = DateTime.Now.AddDays(-10),
							EndDate = DateTime.Now.AddDays(-5),
							CinemaId = 1,
							ProducerId = 4,
							MovieCategory = MovieCategory.Comedy
						},
						new Movie()
						{
							Name = "Sesir profesora Kosete Vujica",
							Description = "This is the movie description",
							Price = 8.50,
							ImageURL = "https://ibb.co/sJfzRGs",
							StartDate = DateTime.Now.AddDays(-10),
							EndDate = DateTime.Now.AddDays(-2),
							CinemaId = 1,
							ProducerId = 5,
							MovieCategory = MovieCategory.Documentary
						},
						new Movie()
						{
							Name = "Samac u braku",
							Description = "This is the movie description",
							Price = 12.50,
							ImageURL = "https://ibb.co/8bWYmPs",
							StartDate = DateTime.Now.AddDays(3),
							EndDate = DateTime.Now.AddDays(20),
							CinemaId = 1,
							ProducerId = 5,
							MovieCategory = MovieCategory.Romance
						},

                        new Movie()
                        {
                            Name = "Necista krv",
                            Description = "This is the movie description",
                            Price = 12.50,
                            ImageURL = "https://ibb.co/h7ppPBw",
                            StartDate = DateTime.Now.AddDays(3),
                            EndDate = DateTime.Now.AddDays(20),
                            CinemaId = 1,
                            ProducerId = 12,
                            MovieCategory = MovieCategory.Drama
                        },
                        new Movie()
                        {
                            Name = "Munje",
                            Description = "This is the movie description",
                            Price = 12.50,
                            ImageURL = "https://ibb.co/PmFrPK2",
                            StartDate = DateTime.Now.AddDays(3),
                            EndDate = DateTime.Now.AddDays(20),
                            CinemaId = 1,
                            ProducerId = 3,
                            MovieCategory = MovieCategory.Comedy
                        },
                        new Movie()
                        {
                            Name = "Mrtav 'ladan",
                            Description = "This is the movie description",
                            Price = 9.50,
                            ImageURL = "https://ibb.co/D9bwPZT",
                            StartDate = DateTime.Now.AddDays(3),
                            EndDate = DateTime.Now.AddDays(20),
                            CinemaId = 1,
                            ProducerId = 6,
                            MovieCategory = MovieCategory.Comedy
                        },
                        new Movie()
                        {
                            Name = "Mala nocna muzika",
                            Description = "This is the movie description",
                            Price = 11.50,
                            ImageURL = "https://ibb.co/fSsMgLZ",
                            StartDate = DateTime.Now.AddDays(3),
                            EndDate = DateTime.Now.AddDays(20),
                            CinemaId = 1,
                            ProducerId = 7,
                            MovieCategory = MovieCategory.Comedy
                        },
                        new Movie()
                        {
                            Name = "Lajanje na zvezde",
                            Description = "This is the movie description",
                            Price = 8.50,
                            ImageURL = "https://ibb.co/qNhy81Q",
                            StartDate = DateTime.Now.AddDays(3),
                            EndDate = DateTime.Now.AddDays(20),
                            CinemaId = 1,
                            ProducerId = 5,
                            MovieCategory = MovieCategory.Romance
                        },
                        new Movie()
                        {
                            Name = "Kad porastem bicu kengur",
                            Description = "This is the movie description",
                            Price = 9.50,
                            ImageURL = "https://ibb.co/tc3JxjD",
                            StartDate = DateTime.Now.AddDays(3),
                            EndDate = DateTime.Now.AddDays(20),
                            CinemaId = 1,
                            ProducerId = 5,
                            MovieCategory = MovieCategory.Comedy
                        },
                        new Movie()
                        {
                            Name = "Kad porastem bicu kengur",
                            Description = "This is the movie description",
                            Price = 9.50,
                            ImageURL = "https://ibb.co/tc3JxjD",
                            StartDate = DateTime.Now.AddDays(3),
                            EndDate = DateTime.Now.AddDays(20),
                            CinemaId = 1,
                            ProducerId = 3,
                            MovieCategory = MovieCategory.Comedy
                        },
                        new Movie()
                        {
                            Name = "Balkanska medja",
                            Description = "This is the movie description",
                            Price = 7.50,
                            ImageURL = "https://ibb.co/3FLhYZX",
                            StartDate = DateTime.Now.AddDays(3),
                            EndDate = DateTime.Now.AddDays(20),
                            CinemaId = 1,
                            ProducerId = 8,
                            MovieCategory = MovieCategory.Action
                        },
                        new Movie()
                        {
                            Name = "Taksi bluz",
                            Description = "This is the movie description",
                            Price = 9.50,
                            ImageURL = "https://ibb.co/n1wSBz4",
                            StartDate = DateTime.Now.AddDays(3),
                            EndDate = DateTime.Now.AddDays(20),
                            CinemaId = 1,
                            ProducerId = 9,
                            MovieCategory = MovieCategory.Comedy
                        },
                        new Movie()
                        {
                            Name = "Falsifikator",
                            Description = "This is the movie description",
                            Price = 9.50,
                            ImageURL = "https://ibb.co/JCfYYps",
                            StartDate = DateTime.Now.AddDays(3),
                            EndDate = DateTime.Now.AddDays(20),
                            CinemaId = 1,
                            ProducerId = 10,
                            MovieCategory = MovieCategory.Drama
                        },
                        new Movie()
                        {
                            Name = "Branio sam Mladu Bosnu",
                            Description = "This is the movie description",
                            Price = 7.50,
                            ImageURL = "https://ibb.co/YPQTmmb",
                            StartDate = DateTime.Now.AddDays(3),
                            EndDate = DateTime.Now.AddDays(20),
                            CinemaId = 1,
                            ProducerId = 4,
                            MovieCategory = MovieCategory.Drama
                        },
                        new Movie()
                        {
                            Name = "Boomerang",
                            Description = "This is the movie description",
                            Price = 10.50,
                            ImageURL = "https://ibb.co/pzbrH9n",
                            StartDate = DateTime.Now.AddDays(3),
                            EndDate = DateTime.Now.AddDays(20),
                            CinemaId = 1,
                            ProducerId = 11,
                            MovieCategory = MovieCategory.Comedy
                        }
                    });
					context.SaveChanges();
				}
				//Actors & Movies
				if (!context.Actors_Movies.Any())
				{
					context.Actors_Movies.AddRange(new List<Actor_Movie>()
					{
						new Actor_Movie()
						{
							ActorId = 1,
							MovieId = 8
						},
						new Actor_Movie()
						{
							ActorId = 2,
							MovieId = 13
						},
                        new Actor_Movie()
                        {
                            ActorId = 2,
                            MovieId = 10
                        },
                         new Actor_Movie()
						{
							ActorId = 3,
							MovieId = 15
						},
						 new Actor_Movie()
						{
							ActorId = 4,
							MovieId = 1
						},

						new Actor_Movie()
						{
							ActorId = 5,
							MovieId = 3
						},
                        new Actor_Movie()
                        {
                            ActorId = 5,
                            MovieId = 9
                        },
                        new Actor_Movie()
						{
							ActorId = 6,
							MovieId = 7
						},
						new Actor_Movie()
						{
							ActorId = 7,
							MovieId = 16
						},
                        new Actor_Movie()
                        {
                            ActorId = 8,
                            MovieId = 12
                        },

                        new Actor_Movie()
						{
							ActorId = 9,
							MovieId = 9
						},
                        new Actor_Movie()
                        {
                            ActorId = 10,
                            MovieId = 17
                        },
                        new Actor_Movie()
                        {
                            ActorId = 11,
                            MovieId = 1
                        },
                        new Actor_Movie()
                        {
                            ActorId = 12,
                            MovieId = 11
                        },
                        new Actor_Movie()
                        {
                            ActorId = 13,
                            MovieId = 5
                        },
                        new Actor_Movie()
                        {
                            ActorId = 13,
                            MovieId = 6
                        },
                        new Actor_Movie()
                        {
                            ActorId = 14,
                            MovieId = 12
                        },
                        new Actor_Movie()
                        {
                            ActorId = 15,
                            MovieId = 17
                        },
                        new Actor_Movie()
                        {
                            ActorId = 16,
                            MovieId = 7
                        },
                        new Actor_Movie()
                        {
                            ActorId = 17,
                            MovieId = 2
                        },
                        new Actor_Movie()
                        {
                            ActorId = 17,
                            MovieId = 10
                        },
                        new Actor_Movie()
                        {
                            ActorId = 11,
                            MovieId = 12
                        },
                        new Actor_Movie()
                        {
                            ActorId = 18,
                            MovieId = 3
                        },
                        new Actor_Movie()
                        {
                            ActorId = 19,
                            MovieId = 3
                        },
                        new Actor_Movie()
                        {
                            ActorId = 20,
                            MovieId = 1
                        },
                        new Actor_Movie()
                        {
                            ActorId = 20,
                            MovieId = 15
                        },
                        new Actor_Movie()
                        {
                            ActorId = 21,
                            MovieId = 11
                        },
                        new Actor_Movie()
                        {
                            ActorId = 22,
                            MovieId = 17
                        },
                        new Actor_Movie()
                        {
                            ActorId = 23,
                            MovieId = 7
                        },
                        new Actor_Movie()
                        {
                            ActorId = 24,
                            MovieId = 6
                        },
                        new Actor_Movie()
                        {
                            ActorId = 25,
                            MovieId = 15
                        },
                        new Actor_Movie()
                        {
                            ActorId = 26,
                            MovieId = 8
                        },
                        new Actor_Movie()
                        {
                            ActorId = 26,
                            MovieId = 11
                        },
                        new Actor_Movie()
                        {
                            ActorId = 27,
                            MovieId = 14
                        },
                        new Actor_Movie()
                        {
                            ActorId = 28,
                            MovieId = 7
                        },
                        new Actor_Movie()
                        {
                            ActorId = 29,
                            MovieId = 4
                        },
                        new Actor_Movie()
                        {
                            ActorId = 30,
                            MovieId = 5
                        },
                        new Actor_Movie()
                        {
                            ActorId = 30,
                            MovieId = 13
                        },
                        new Actor_Movie()
                        {
                            ActorId = 31,
                            MovieId = 5
                        },
                    });
					context.SaveChanges();
				}
			}

		}

		public static async Task SeedUsersAndRolesAsync(IApplicationBuilder applicationBuilder)
		{
			using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
			{

				//Roles
				var roleManager = serviceScope.ServiceProvider.GetRequiredService<RoleManager<IdentityRole>>();

				if (!await roleManager.RoleExistsAsync(UserRoles.Admin))
					await roleManager.CreateAsync(new IdentityRole(UserRoles.Admin));
				if (!await roleManager.RoleExistsAsync(UserRoles.User))
					await roleManager.CreateAsync(new IdentityRole(UserRoles.User));

				//Users
				var userManager = serviceScope.ServiceProvider.GetRequiredService<UserManager<ApplicationUser>>();
				string adminUserEmail = "admin@etickets.com";

				var adminUser = await userManager.FindByEmailAsync(adminUserEmail);
				if (adminUser == null)
				{
					var newAdminUser = new ApplicationUser()
					{
						FullName = "Admin User",
						UserName = "admin-user",
						Email = adminUserEmail,
						EmailConfirmed = true
					};
					await userManager.CreateAsync(newAdminUser, "andjela@1234?");
					await userManager.AddToRoleAsync(newAdminUser, UserRoles.Admin);
				}


				string appUserEmail = "user@etickets.com";

				var appUser = await userManager.FindByEmailAsync(appUserEmail);
				if (appUser == null)
				{
					var newAppUser = new ApplicationUser()
					{
						FullName = "Application User",
						UserName = "app-user",
						Email = appUserEmail,
						EmailConfirmed = true
					};
					await userManager.CreateAsync(newAppUser, "user@1234?");
					await userManager.AddToRoleAsync(newAppUser, UserRoles.User);
				}
			}
		}
	}
}
