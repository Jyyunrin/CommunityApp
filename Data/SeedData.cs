using System;
using CommunityApp.Model;
using Microsoft.EntityFrameworkCore;

namespace CommunityApp.Data;

public static class SeedData
{
    public static void Seed(this ModelBuilder modelBuilder) {
        modelBuilder.Entity<City>().HasData(
            GetCity()
        );

        modelBuilder.Entity<Province>().HasData(
            GetProvince()
        );

    }

    public static List<City> GetCity() {
        List<City> cities = new List<City>() {
            new City() {
                CityId = 1,
                CityName = "Vancouver",
                Population = 28000000,
                ProvinceCode = "BC"

            },
            new City() {
                CityId = 2,
                CityName = "Victoria",
                Population = 600000,
                ProvinceCode = "BC"

            },
            new City() {
                CityId = 3,
                CityName = "Langley",
                Population = 300000,
                ProvinceCode = "BC"

            },
            new City() {
                CityId = 4,
                CityName = "Calgary",
                Population = 12000000,
                ProvinceCode = "AB"

            },
            new City() {
                CityId = 5,
                CityName = "Edmonton",
                Population = 900000,
                ProvinceCode = "AB"

            },
            new City() {
                CityId = 6,
                CityName = "Leduc",
                Population = 34000,
                ProvinceCode = "AB"

            },
            new City() {
                CityId = 7,
                CityName = "Toronto",
                Population = 3000000,
                ProvinceCode = "ON"

            },
            new City() {
                CityId = 8,
                CityName = "Ottawa",
                Population = 850000,
                ProvinceCode = "ON"

            },
            new City() {
                CityId = 9,
                CityName = "Brampton",
                Population = 340000,
                ProvinceCode = "ON"

            }
        };
        return cities;
    }

    public static List<Province> GetProvince() {
        List<Province> provinces = new List<Province>() {
            new Province() {
                ProvinceCode = "BC",
                ProvinceName = "British Columbia"
            },
            new Province() {
                ProvinceCode = "AB",
                ProvinceName = "Alberta"
            },
            new Province() {
                ProvinceCode = "ON",
                ProvinceName = "Ontario"
            }
        };
        return provinces;
    }
}
