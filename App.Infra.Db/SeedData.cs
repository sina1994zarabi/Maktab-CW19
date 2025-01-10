using App.Domain.Core.Entities;
using App.Domain.Core.Enums;
using App.Infra.Data.Ef;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace App.Infra.Db
{
	public static class SeedData
	{
		public static void Initialize(IServiceProvider serviceProvider)
		{
			using (var context = new AppDbContext(serviceProvider.GetRequiredService<DbContextOptions<AppDbContext>>()))
			{
				if (context.Users.Any())
				{ return; }
				context.Users.AddRange(
					new User
					{
						FirstName = "سینا",
						LastName = "ضرابی",
						CreatedAt = DateTime.Now,
						DateOfBirth = new DateTime(1994, 8, 27),
						IdentificationNumber = "3241327892",
						PhoneNumber = "09367559646",
						SubscriptionType = Subscription.برنز,
						Gender = Gender.مرد
					},
					new User
					{
						FirstName = "بیان",
						LastName = "ضرابی",
						CreatedAt = DateTime.Now,
						DateOfBirth = new DateTime(1985, 5, 15),
						IdentificationNumber = "0987654321",
						PhoneNumber = "09876543210",
						SubscriptionType = Subscription.نقره,
						Gender = Gender.زن
					},
					new User
					{
						FirstName = "محمد",
						LastName = "طلایی",
						CreatedAt = DateTime.Now,
						DateOfBirth = new DateTime(1992, 3, 22),
						IdentificationNumber = "1122334455",
						PhoneNumber = "01122334455",
						SubscriptionType = Subscription.طلایی,
						Gender = Gender.زن
					});
				context.SaveChanges();
			}
		}
	}
}