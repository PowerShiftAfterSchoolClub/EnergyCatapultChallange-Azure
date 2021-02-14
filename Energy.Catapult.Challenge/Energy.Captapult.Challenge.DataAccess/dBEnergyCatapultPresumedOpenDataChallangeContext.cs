using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace Energy.Captapult.Challenge.DataAccess
{
    public partial class dBEnergyCatapultPresumedOpenDataChallangeContext : DbContext
    {
        public dBEnergyCatapultPresumedOpenDataChallangeContext()
        {
           
        }

        public dBEnergyCatapultPresumedOpenDataChallangeContext(DbContextOptions<dBEnergyCatapultPresumedOpenDataChallangeContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Asset> Assets { get; set; }
        public virtual DbSet<CalendarMap> CalendarMaps { get; set; }
        public virtual DbSet<DemandTrainSet0> DemandTrainSet0s { get; set; }
        public virtual DbSet<PvTrainSet0> PvTrainSet0s { get; set; }
        public virtual DbSet<Result> Results { get; set; }
        public virtual DbSet<Task> Tasks { get; set; }
        public virtual DbSet<Task0ForecastCalendarMapWithForecastWeatherHh> Task0ForecastCalendarMapWithForecastWeatherHhs { get; set; }
        public virtual DbSet<Task0ForecastsPvandDemandRun1> Task0ForecastsPvandDemandRun1s { get; set; }
        public virtual DbSet<Task0TrainingCalWeatherHh> Task0TrainingCalWeatherHhs { get; set; }
        public virtual DbSet<Task0TrainingCalendarDemandWeatherHh> Task0TrainingCalendarDemandWeatherHhs { get; set; }
        public virtual DbSet<Task0TrainingCalendarMap> Task0TrainingCalendarMaps { get; set; }
        public virtual DbSet<Task0TrainingCalendarPvweatherHh> Task0TrainingCalendarPvweatherHhs { get; set; }
        public virtual DbSet<Task0forecastCalendarMap> Task0forecastCalendarMaps { get; set; }
        public virtual DbSet<WeatherTrainSet0> WeatherTrainSet0s { get; set; }
        public virtual DbSet<WeatherTrainSet0Hh> WeatherTrainSet0Hhs { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=serverenergycatapult.database.windows.net;Initial Catalog=dBEnergyCatapultPresumedOpenDataChallange;User Id=USER;Password=NO");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<Asset>(entity =>
            {
                entity.Property(e => e.AssetId).HasColumnName("assetID");

                entity.Property(e => e.AssetName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("assetName");

                entity.Property(e => e.AssetType)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("assetType");

                entity.Property(e => e.CapacityMwh)
                    .HasColumnType("decimal(10, 3)")
                    .HasColumnName("capacityMWh");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("createdBy")
                    .HasDefaultValueSql("(user_name())");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("createdDate")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.LocationLatitude)
                    .HasColumnType("decimal(10, 3)")
                    .HasColumnName("locationLatitude");

                entity.Property(e => e.LocationLongitude)
                    .HasColumnType("decimal(10, 3)")
                    .HasColumnName("locationLongitude");

                entity.Property(e => e.LocationName)
                    .HasMaxLength(50)
                    .HasColumnName("locationName");

                entity.Property(e => e.PowerMw)
                    .HasColumnType("decimal(10, 3)")
                    .HasColumnName("powerMW");
            });

            modelBuilder.Entity<CalendarMap>(entity =>
            {
                entity.HasKey(e => e.DateTimeUtc);

                entity.ToTable("CalendarMap");

                entity.Property(e => e.DateTimeUtc).HasColumnName("dateTimeUTC");

                entity.Property(e => e.BankHoliday)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("bankHoliday");

                entity.Property(e => e.DateTimeLocal).HasColumnName("dateTimeLocal");

                entity.Property(e => e.DayOfWeek)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasColumnName("dayOfWeek")
                    .IsFixedLength(true);

                entity.Property(e => e.DayOfWeekNumber).HasColumnName("dayOfWeekNumber");

                entity.Property(e => e.HourNumber).HasColumnName("hourNumber");

                entity.Property(e => e.HourText)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasColumnName("hourText")
                    .IsFixedLength(true);

                entity.Property(e => e.MonthName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("monthName");

                entity.Property(e => e.MonthNum).HasColumnName("monthNum");

                entity.Property(e => e.SettlementPeriod).HasColumnName("settlementPeriod");

                entity.Property(e => e.SummerWinter)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("summerWinter");

                entity.Property(e => e.TimeOfDayLocal).HasColumnName("timeOfDayLocal");

                entity.Property(e => e.WeekNumber).HasColumnName("weekNumber");

                entity.Property(e => e.WorkingDay)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("workingDay");

                entity.Property(e => e.Year).HasColumnName("year");
            });

            modelBuilder.Entity<DemandTrainSet0>(entity =>
            {
                entity.HasKey(e => e.DateTimeUtc);

                entity.ToTable("demand_train_set0");

                entity.Property(e => e.DateTimeUtc).HasColumnName("dateTimeUTC");

                entity.Property(e => e.RawDemandMw).HasColumnName("rawDemand_MW");
            });

            modelBuilder.Entity<PvTrainSet0>(entity =>
            {
                entity.HasKey(e => e.DateTimeUtc);

                entity.ToTable("pv_train_set0");

                entity.Property(e => e.DateTimeUtc).HasColumnName("dateTimeUTC");

                entity.Property(e => e.RawIrradianceWm2).HasColumnName("rawIrradiance_Wm_2");

                entity.Property(e => e.RawPanelTempC).HasColumnName("rawPanel_temp_C");

                entity.Property(e => e.RawPvPowerMw).HasColumnName("rawPV_power_mw");
            });

            modelBuilder.Entity<Result>(entity =>
            {
                entity.HasKey(e => e.Datetime);

                entity.ToTable("results");

                entity.Property(e => e.Datetime).HasColumnName("datetime");

                entity.Property(e => e.ChargeMw).HasColumnName("charge_MW");

                entity.Property(e => e.K).HasColumnName("k");

                entity.Property(e => e.RunDateTime).HasColumnName("runDateTime");

                entity.Property(e => e.RunId).HasColumnName("runID");

                entity.Property(e => e.TaksSoCmwh).HasColumnName("taksSoCMWh");

                entity.Property(e => e.TaskBatteryChargeMw).HasColumnName("taskBatteryChargeMW");

                entity.Property(e => e.TaskBatteryDischargeMw).HasColumnName("taskBatteryDischargeMW");

                entity.Property(e => e.TaskBatteryNetMw).HasColumnName("taskBatteryNetMW");

                entity.Property(e => e.TaskChargePv).HasColumnName("taskChargePV");

                entity.Property(e => e.TaskForecastDemandMw).HasColumnName("taskForecastDemandMW");

                entity.Property(e => e.TaskForecsatPvmw).HasColumnName("taskForecsatPVMW");

                entity.Property(e => e.TaskGridTopUpMw).HasColumnName("taskGridTopUpMW");

                entity.Property(e => e.TaskNetDemandMw).HasColumnName("taskNetDemandMW");
            });

            modelBuilder.Entity<Task>(entity =>
            {
                entity.Property(e => e.TaskId).HasColumnName("taskID");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("createdBy")
                    .HasDefaultValueSql("(user_name())");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("createdDate")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.FromDate)
                    .HasColumnType("date")
                    .HasColumnName("fromDate");

                entity.Property(e => e.TaskName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("taskName");

                entity.Property(e => e.ToDate)
                    .HasColumnType("date")
                    .HasColumnName("toDate");
            });

            modelBuilder.Entity<Task0ForecastCalendarMapWithForecastWeatherHh>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("task0ForecastCalendarMapWithForecastWeatherHH");

                entity.Property(e => e.BankHoliday)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("bankHoliday");

                entity.Property(e => e.DateTimeLocal).HasColumnName("dateTimeLocal");

                entity.Property(e => e.DateTimeUtc).HasColumnName("dateTimeUTC");

                entity.Property(e => e.DayOfWeek)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasColumnName("dayOfWeek")
                    .IsFixedLength(true);

                entity.Property(e => e.DayOfWeekNumber).HasColumnName("dayOfWeekNumber");

                entity.Property(e => e.HourNumber).HasColumnName("hourNumber");

                entity.Property(e => e.HourText)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasColumnName("hourText")
                    .IsFixedLength(true);

                entity.Property(e => e.MonthName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("monthName");

                entity.Property(e => e.MonthNum).HasColumnName("monthNum");

                entity.Property(e => e.SettlementPeriod).HasColumnName("settlementPeriod");

                entity.Property(e => e.SolarLocation1).HasColumnName("solar_location1");

                entity.Property(e => e.SolarLocation2).HasColumnName("solar_location2");

                entity.Property(e => e.SolarLocation3).HasColumnName("solar_location3");

                entity.Property(e => e.SolarLocation4).HasColumnName("solar_location4");

                entity.Property(e => e.SolarLocation5).HasColumnName("solar_location5");

                entity.Property(e => e.SolarLocation6).HasColumnName("solar_location6");

                entity.Property(e => e.SummerWinter)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("summerWinter");

                entity.Property(e => e.TempLocation1).HasColumnName("temp_location1");

                entity.Property(e => e.TempLocation2).HasColumnName("temp_location2");

                entity.Property(e => e.TempLocation3).HasColumnName("temp_location3");

                entity.Property(e => e.TempLocation4).HasColumnName("temp_location4");

                entity.Property(e => e.TempLocation5).HasColumnName("temp_location5");

                entity.Property(e => e.TempLocation6).HasColumnName("temp_location6");

                entity.Property(e => e.TimeOfDayLocal).HasColumnName("timeOfDayLocal");

                entity.Property(e => e.WeekNumber).HasColumnName("weekNumber");

                entity.Property(e => e.WorkingDay)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("workingDay");

                entity.Property(e => e.Year).HasColumnName("year");
            });

            modelBuilder.Entity<Task0ForecastsPvandDemandRun1>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("task0ForecastsPVandDemand_Run1");

                entity.Property(e => e.DateTimeUtc).HasColumnName("dateTimeUTC");

                entity.Property(e => e.Task0ForecastDemandMw).HasColumnName("task0ForecastDemandMW");

                entity.Property(e => e.Task0ForecsatPv).HasColumnName("task0ForecsatPV");

                entity.Property(e => e.TaskName)
                    .HasMaxLength(10)
                    .HasColumnName("taskName")
                    .IsFixedLength(true);
            });

            modelBuilder.Entity<Task0TrainingCalWeatherHh>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("task0TrainingCalWeatherHH");

                entity.Property(e => e.BankHoliday)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("bankHoliday");

                entity.Property(e => e.DateTimeLocal).HasColumnName("dateTimeLocal");

                entity.Property(e => e.DateTimeUtc).HasColumnName("dateTimeUTC");

                entity.Property(e => e.DayOfWeek)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasColumnName("dayOfWeek")
                    .IsFixedLength(true);

                entity.Property(e => e.DayOfWeekNumber).HasColumnName("dayOfWeekNumber");

                entity.Property(e => e.HourNumber).HasColumnName("hourNumber");

                entity.Property(e => e.HourText)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasColumnName("hourText")
                    .IsFixedLength(true);

                entity.Property(e => e.MonthName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("monthName");

                entity.Property(e => e.MonthNum).HasColumnName("monthNum");

                entity.Property(e => e.SettlementPeriod).HasColumnName("settlementPeriod");

                entity.Property(e => e.SolarLocation1).HasColumnName("solar_location1");

                entity.Property(e => e.SolarLocation2).HasColumnName("solar_location2");

                entity.Property(e => e.SolarLocation3).HasColumnName("solar_location3");

                entity.Property(e => e.SolarLocation4).HasColumnName("solar_location4");

                entity.Property(e => e.SolarLocation5).HasColumnName("solar_location5");

                entity.Property(e => e.SolarLocation6).HasColumnName("solar_location6");

                entity.Property(e => e.SummerWinter)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("summerWinter");

                entity.Property(e => e.TempLocation1).HasColumnName("temp_location1");

                entity.Property(e => e.TempLocation2).HasColumnName("temp_location2");

                entity.Property(e => e.TempLocation3).HasColumnName("temp_location3");

                entity.Property(e => e.TempLocation4).HasColumnName("temp_location4");

                entity.Property(e => e.TempLocation5).HasColumnName("temp_location5");

                entity.Property(e => e.TempLocation6).HasColumnName("temp_location6");

                entity.Property(e => e.TimeOfDayLocal).HasColumnName("timeOfDayLocal");

                entity.Property(e => e.WeekNumber).HasColumnName("weekNumber");

                entity.Property(e => e.WorkingDay)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("workingDay");

                entity.Property(e => e.Year).HasColumnName("year");
            });

            modelBuilder.Entity<Task0TrainingCalendarDemandWeatherHh>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("task0TrainingCalendarDemandWeatherHH");

                entity.Property(e => e.BankHoliday)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("bankHoliday");

                entity.Property(e => e.DateTimeLocal).HasColumnName("dateTimeLocal");

                entity.Property(e => e.DateTimeUtc).HasColumnName("dateTimeUTC");

                entity.Property(e => e.DayOfWeek)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasColumnName("dayOfWeek")
                    .IsFixedLength(true);

                entity.Property(e => e.DayOfWeekNumber).HasColumnName("dayOfWeekNumber");

                entity.Property(e => e.HourNumber).HasColumnName("hourNumber");

                entity.Property(e => e.HourText)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasColumnName("hourText")
                    .IsFixedLength(true);

                entity.Property(e => e.MonthName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("monthName");

                entity.Property(e => e.MonthNum).HasColumnName("monthNum");

                entity.Property(e => e.RawDemandMw).HasColumnName("rawDemand_mw");

                entity.Property(e => e.SettlementPeriod).HasColumnName("settlementPeriod");

                entity.Property(e => e.SolarLocation1).HasColumnName("solar_location1");

                entity.Property(e => e.SolarLocation2).HasColumnName("solar_location2");

                entity.Property(e => e.SolarLocation3).HasColumnName("solar_location3");

                entity.Property(e => e.SolarLocation4).HasColumnName("solar_location4");

                entity.Property(e => e.SolarLocation5).HasColumnName("solar_location5");

                entity.Property(e => e.SolarLocation6).HasColumnName("solar_location6");

                entity.Property(e => e.SummerWinter)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("summerWinter");

                entity.Property(e => e.TempLocation1).HasColumnName("temp_location1");

                entity.Property(e => e.TempLocation2).HasColumnName("temp_location2");

                entity.Property(e => e.TempLocation3).HasColumnName("temp_location3");

                entity.Property(e => e.TempLocation4).HasColumnName("temp_location4");

                entity.Property(e => e.TempLocation5).HasColumnName("temp_location5");

                entity.Property(e => e.TempLocation6).HasColumnName("temp_location6");

                entity.Property(e => e.TimeOfDayLocal).HasColumnName("timeOfDayLocal");

                entity.Property(e => e.WeekNumber).HasColumnName("weekNumber");

                entity.Property(e => e.WorkingDay)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("workingDay");

                entity.Property(e => e.Year).HasColumnName("year");
            });

            modelBuilder.Entity<Task0TrainingCalendarMap>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("task0TrainingCalendarMap");

                entity.Property(e => e.BankHoliday)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("bankHoliday");

                entity.Property(e => e.DateTimeLocal).HasColumnName("dateTimeLocal");

                entity.Property(e => e.DateTimeUtc).HasColumnName("dateTimeUTC");

                entity.Property(e => e.DayOfWeek)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasColumnName("dayOfWeek")
                    .IsFixedLength(true);

                entity.Property(e => e.DayOfWeekNumber).HasColumnName("dayOfWeekNumber");

                entity.Property(e => e.HourNumber).HasColumnName("hourNumber");

                entity.Property(e => e.HourText)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasColumnName("hourText")
                    .IsFixedLength(true);

                entity.Property(e => e.MonthName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("monthName");

                entity.Property(e => e.MonthNum).HasColumnName("monthNum");

                entity.Property(e => e.SettlementPeriod).HasColumnName("settlementPeriod");

                entity.Property(e => e.SummerWinter)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("summerWinter");

                entity.Property(e => e.TimeOfDayLocal).HasColumnName("timeOfDayLocal");

                entity.Property(e => e.WeekNumber).HasColumnName("weekNumber");

                entity.Property(e => e.WorkingDay)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("workingDay");

                entity.Property(e => e.Year).HasColumnName("year");
            });

            modelBuilder.Entity<Task0TrainingCalendarPvweatherHh>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("task0TrainingCalendarPVWeatherHH");

                entity.Property(e => e.BankHoliday)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("bankHoliday");

                entity.Property(e => e.DateTimeLocal).HasColumnName("dateTimeLocal");

                entity.Property(e => e.DateTimeUtc).HasColumnName("dateTimeUTC");

                entity.Property(e => e.DayOfWeek)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasColumnName("dayOfWeek")
                    .IsFixedLength(true);

                entity.Property(e => e.DayOfWeekNumber).HasColumnName("dayOfWeekNumber");

                entity.Property(e => e.HourNumber).HasColumnName("hourNumber");

                entity.Property(e => e.HourText)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasColumnName("hourText")
                    .IsFixedLength(true);

                entity.Property(e => e.MonthName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("monthName");

                entity.Property(e => e.MonthNum).HasColumnName("monthNum");

                entity.Property(e => e.RawPvPowerMw).HasColumnName("rawPV_power_mw");

                entity.Property(e => e.SettlementPeriod).HasColumnName("settlementPeriod");

                entity.Property(e => e.SolarLocation1).HasColumnName("solar_location1");

                entity.Property(e => e.SolarLocation2).HasColumnName("solar_location2");

                entity.Property(e => e.SolarLocation3).HasColumnName("solar_location3");

                entity.Property(e => e.SolarLocation4).HasColumnName("solar_location4");

                entity.Property(e => e.SolarLocation5).HasColumnName("solar_location5");

                entity.Property(e => e.SolarLocation6).HasColumnName("solar_location6");

                entity.Property(e => e.SummerWinter)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("summerWinter");

                entity.Property(e => e.TempLocation1).HasColumnName("temp_location1");

                entity.Property(e => e.TempLocation2).HasColumnName("temp_location2");

                entity.Property(e => e.TempLocation3).HasColumnName("temp_location3");

                entity.Property(e => e.TempLocation4).HasColumnName("temp_location4");

                entity.Property(e => e.TempLocation5).HasColumnName("temp_location5");

                entity.Property(e => e.TempLocation6).HasColumnName("temp_location6");

                entity.Property(e => e.TimeOfDayLocal).HasColumnName("timeOfDayLocal");

                entity.Property(e => e.WeekNumber).HasColumnName("weekNumber");

                entity.Property(e => e.WorkingDay)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("workingDay");

                entity.Property(e => e.Year).HasColumnName("year");
            });

            modelBuilder.Entity<Task0forecastCalendarMap>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("task0forecastCalendarMap");

                entity.Property(e => e.BankHoliday)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("bankHoliday");

                entity.Property(e => e.DateTimeLocal).HasColumnName("dateTimeLocal");

                entity.Property(e => e.DateTimeUtc).HasColumnName("dateTimeUTC");

                entity.Property(e => e.DayOfWeek)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasColumnName("dayOfWeek")
                    .IsFixedLength(true);

                entity.Property(e => e.DayOfWeekNumber).HasColumnName("dayOfWeekNumber");

                entity.Property(e => e.HourNumber).HasColumnName("hourNumber");

                entity.Property(e => e.HourText)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasColumnName("hourText")
                    .IsFixedLength(true);

                entity.Property(e => e.MonthName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("monthName");

                entity.Property(e => e.MonthNum).HasColumnName("monthNum");

                entity.Property(e => e.SettlementPeriod).HasColumnName("settlementPeriod");

                entity.Property(e => e.SummerWinter)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("summerWinter");

                entity.Property(e => e.TimeOfDayLocal).HasColumnName("timeOfDayLocal");

                entity.Property(e => e.WeekNumber).HasColumnName("weekNumber");

                entity.Property(e => e.WorkingDay)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("workingDay");

                entity.Property(e => e.Year).HasColumnName("year");
            });

            modelBuilder.Entity<WeatherTrainSet0>(entity =>
            {
                entity.HasKey(e => e.DatetimeUtc);

                entity.ToTable("weather_train_set0");

                entity.Property(e => e.DatetimeUtc).HasColumnName("datetimeUTC");

                entity.Property(e => e.SolarLocation1).HasColumnName("solar_location1");

                entity.Property(e => e.SolarLocation2).HasColumnName("solar_location2");

                entity.Property(e => e.SolarLocation3).HasColumnName("solar_location3");

                entity.Property(e => e.SolarLocation4).HasColumnName("solar_location4");

                entity.Property(e => e.SolarLocation5).HasColumnName("solar_location5");

                entity.Property(e => e.SolarLocation6).HasColumnName("solar_location6");

                entity.Property(e => e.TempLocation1).HasColumnName("temp_location1");

                entity.Property(e => e.TempLocation2).HasColumnName("temp_location2");

                entity.Property(e => e.TempLocation3).HasColumnName("temp_location3");

                entity.Property(e => e.TempLocation4).HasColumnName("temp_location4");

                entity.Property(e => e.TempLocation5).HasColumnName("temp_location5");

                entity.Property(e => e.TempLocation6).HasColumnName("temp_location6");
            });

            modelBuilder.Entity<WeatherTrainSet0Hh>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("weather_train_set0_HH");

                entity.Property(e => e.DateTimeUtc).HasColumnName("dateTimeUTC");

                entity.Property(e => e.SolarLocation1).HasColumnName("solar_location1");

                entity.Property(e => e.SolarLocation2).HasColumnName("solar_location2");

                entity.Property(e => e.SolarLocation3).HasColumnName("solar_location3");

                entity.Property(e => e.SolarLocation4).HasColumnName("solar_location4");

                entity.Property(e => e.SolarLocation5).HasColumnName("solar_location5");

                entity.Property(e => e.SolarLocation6).HasColumnName("solar_location6");

                entity.Property(e => e.TempLocation1).HasColumnName("temp_location1");

                entity.Property(e => e.TempLocation2).HasColumnName("temp_location2");

                entity.Property(e => e.TempLocation3).HasColumnName("temp_location3");

                entity.Property(e => e.TempLocation4).HasColumnName("temp_location4");

                entity.Property(e => e.TempLocation5).HasColumnName("temp_location5");

                entity.Property(e => e.TempLocation6).HasColumnName("temp_location6");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
