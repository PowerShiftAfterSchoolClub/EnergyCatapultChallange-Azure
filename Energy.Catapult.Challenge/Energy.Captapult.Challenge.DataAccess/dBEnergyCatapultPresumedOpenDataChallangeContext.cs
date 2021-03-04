using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

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

        public virtual DbSet<Assets> Assets { get; set; }
        public virtual DbSet<BackupOptResults> BackupOptResults { get; set; }
        public virtual DbSet<CalendarMap> CalendarMap { get; set; }
        public virtual DbSet<CalendarMapOld> CalendarMapOld { get; set; }
        public virtual DbSet<DemandTrainSet0> DemandTrainSet0 { get; set; }
        public virtual DbSet<DemandTrainSet1> DemandTrainSet1 { get; set; }
        public virtual DbSet<DemandTrainSet2> DemandTrainSet2 { get; set; }
        public virtual DbSet<PvTrainSet0> PvTrainSet0 { get; set; }
        public virtual DbSet<PvTrainSet1> PvTrainSet1 { get; set; }
        public virtual DbSet<PvTrainSet2> PvTrainSet2 { get; set; }
        public virtual DbSet<Task0ForecastCalendarMapWithForecastWeatherHh> Task0ForecastCalendarMapWithForecastWeatherHh { get; set; }
        public virtual DbSet<Task0ForecastsPvandDemandRun1> Task0ForecastsPvandDemandRun1 { get; set; }
        public virtual DbSet<Task0TrainingCalWeatherHh> Task0TrainingCalWeatherHh { get; set; }
        public virtual DbSet<Task0TrainingCalendarDemandWeatherHh> Task0TrainingCalendarDemandWeatherHh { get; set; }
        public virtual DbSet<Task0TrainingCalendarMap> Task0TrainingCalendarMap { get; set; }
        public virtual DbSet<Task0TrainingCalendarPvweatherHh> Task0TrainingCalendarPvweatherHh { get; set; }
        public virtual DbSet<Task0forecastCalendarMap> Task0forecastCalendarMap { get; set; }
        public virtual DbSet<Task1ForecastCalendarMap> Task1ForecastCalendarMap { get; set; }
        public virtual DbSet<Task1ForecastCalendarMapWithForecastWeatherHh> Task1ForecastCalendarMapWithForecastWeatherHh { get; set; }
        public virtual DbSet<Task1ForecastsPvandDemandModelComparisons> Task1ForecastsPvandDemandModelComparisons { get; set; }
        public virtual DbSet<Task1ForecastsPvandDemandRun1> Task1ForecastsPvandDemandRun1 { get; set; }
        public virtual DbSet<Task1TrainingCalWeatherHh> Task1TrainingCalWeatherHh { get; set; }
        public virtual DbSet<Task1TrainingCalendarDemandWeatherHh> Task1TrainingCalendarDemandWeatherHh { get; set; }
        public virtual DbSet<Task1TrainingCalendarMap> Task1TrainingCalendarMap { get; set; }
        public virtual DbSet<Task1TrainingCalendarPvweatherHh> Task1TrainingCalendarPvweatherHh { get; set; }
        public virtual DbSet<Task2ForecastCalendarMap> Task2ForecastCalendarMap { get; set; }
        public virtual DbSet<Task2ForecastCalendarMapWithForecastWeatherHh> Task2ForecastCalendarMapWithForecastWeatherHh { get; set; }
        public virtual DbSet<Task2ForecastsPvandDemandRun1> Task2ForecastsPvandDemandRun1 { get; set; }
        public virtual DbSet<Task2ForecastsPvandDemandRun1OptimiseByHand20210228> Task2ForecastsPvandDemandRun1OptimiseByHand20210228 { get; set; }
        public virtual DbSet<Task2ForecastsPvandDemandRun2OptimiseByHand20210302> Task2ForecastsPvandDemandRun2OptimiseByHand20210302 { get; set; }
        public virtual DbSet<Task2TrainingCalWeatherHh> Task2TrainingCalWeatherHh { get; set; }
        public virtual DbSet<Task2TrainingCalendarDemandWeatherHh> Task2TrainingCalendarDemandWeatherHh { get; set; }
        public virtual DbSet<Task2TrainingCalendarMap> Task2TrainingCalendarMap { get; set; }
        public virtual DbSet<Task2TrainingCalendarPvweatherHh> Task2TrainingCalendarPvweatherHh { get; set; }
        public virtual DbSet<Tasks> Tasks { get; set; }
        public virtual DbSet<WeatherTrainSet0> WeatherTrainSet0 { get; set; }
        public virtual DbSet<WeatherTrainSet0Hh> WeatherTrainSet0Hh { get; set; }
        public virtual DbSet<WeatherTrainSet1> WeatherTrainSet1 { get; set; }
        public virtual DbSet<WeatherTrainSet1Hh> WeatherTrainSet1Hh { get; set; }
        public virtual DbSet<WeatherTrainSet2> WeatherTrainSet2 { get; set; }
        public virtual DbSet<WeatherTrainSet2Hh> WeatherTrainSet2Hh { get; set; }
        public virtual DbSet<_10forecastinputsByTask> _10forecastinputsByTask { get; set; }
        public virtual DbSet<_20forecastoutputsByTaskRun> _20forecastoutputsByTaskRun { get; set; }
        public virtual DbSet<_21forecastoutputsByTaskRun> _21forecastoutputsByTaskRun { get; set; }
        public virtual DbSet<_30resultsoptimisation> _30resultsoptimisation { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=serverenergycatapult.database.windows.net;Database=dBEnergyCatapultPresumedOpenDataChallange;User Id=DreamTeam;Password=<PW>;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Assets>(entity =>
            {
                entity.HasKey(e => e.AssetId)
                    .HasName("PK__Assets__7D3DF4F106CA56D2");

                entity.Property(e => e.AssetId).HasColumnName("assetID");

                entity.Property(e => e.AssetName)
                    .IsRequired()
                    .HasColumnName("assetName")
                    .HasMaxLength(50);

                entity.Property(e => e.AssetType)
                    .IsRequired()
                    .HasColumnName("assetType")
                    .HasMaxLength(50);

                entity.Property(e => e.CapacityMwh)
                    .HasColumnName("capacityMWh")
                    .HasColumnType("decimal(10, 3)");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasColumnName("createdBy")
                    .HasMaxLength(255)
                    .HasDefaultValueSql("(user_name())");

                entity.Property(e => e.CreatedDate)
                    .HasColumnName("createdDate")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.LocationLatitude)
                    .HasColumnName("locationLatitude")
                    .HasColumnType("decimal(10, 3)");

                entity.Property(e => e.LocationLongitude)
                    .HasColumnName("locationLongitude")
                    .HasColumnType("decimal(10, 3)");

                entity.Property(e => e.LocationName)
                    .HasColumnName("locationName")
                    .HasMaxLength(50);

                entity.Property(e => e.PowerMw)
                    .HasColumnName("powerMW")
                    .HasColumnType("decimal(10, 3)");
            });

            modelBuilder.Entity<BackupOptResults>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("backupOptResults");

                entity.Property(e => e.ChargeMw).HasColumnName("charge_MW");

                entity.Property(e => e.Datetime).HasColumnName("datetime");

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

            modelBuilder.Entity<CalendarMap>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.BankHoliday)
                    .IsRequired()
                    .HasColumnName("bankHoliday")
                    .HasMaxLength(50);

                entity.Property(e => e.DateTimeLocal).HasColumnName("dateTimeLocal");

                entity.Property(e => e.DateTimeUtc).HasColumnName("dateTimeUTC");

                entity.Property(e => e.DayOfWeek)
                    .IsRequired()
                    .HasColumnName("dayOfWeek")
                    .HasMaxLength(50);

                entity.Property(e => e.DayOfWeekNumber)
                    .IsRequired()
                    .HasColumnName("dayOfWeekNumber")
                    .HasMaxLength(50);

                entity.Property(e => e.HourNumber)
                    .IsRequired()
                    .HasColumnName("hourNumber")
                    .HasMaxLength(50);

                entity.Property(e => e.HourText)
                    .IsRequired()
                    .HasColumnName("hourText")
                    .HasMaxLength(50);

                entity.Property(e => e.MonthName)
                    .IsRequired()
                    .HasColumnName("monthName")
                    .HasMaxLength(50);

                entity.Property(e => e.MonthNum)
                    .IsRequired()
                    .HasColumnName("monthNum")
                    .HasMaxLength(50);

                entity.Property(e => e.SettlementPeriod)
                    .IsRequired()
                    .HasColumnName("settlementPeriod")
                    .HasMaxLength(50);

                entity.Property(e => e.SummerWinter)
                    .IsRequired()
                    .HasColumnName("summerWinter")
                    .HasMaxLength(50);

                entity.Property(e => e.TimeOfDayLocal).HasColumnName("timeOfDayLocal");

                entity.Property(e => e.WeekNumber)
                    .IsRequired()
                    .HasColumnName("weekNumber")
                    .HasMaxLength(50);

                entity.Property(e => e.WorkingDay)
                    .IsRequired()
                    .HasColumnName("workingDay")
                    .HasMaxLength(50);

                entity.Property(e => e.Year).HasColumnName("year");
            });

            modelBuilder.Entity<CalendarMapOld>(entity =>
            {
                entity.HasKey(e => e.DateTimeUtc)
                    .HasName("PK_CalendarMap");

                entity.Property(e => e.DateTimeUtc).HasColumnName("dateTimeUTC");

                entity.Property(e => e.BankHoliday)
                    .IsRequired()
                    .HasColumnName("bankHoliday")
                    .HasMaxLength(50);

                entity.Property(e => e.DateTimeLocal).HasColumnName("dateTimeLocal");

                entity.Property(e => e.DayOfWeek)
                    .IsRequired()
                    .HasColumnName("dayOfWeek")
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.DayOfWeekNumber).HasColumnName("dayOfWeekNumber");

                entity.Property(e => e.HourNumber).HasColumnName("hourNumber");

                entity.Property(e => e.HourText)
                    .IsRequired()
                    .HasColumnName("hourText")
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.MonthName)
                    .IsRequired()
                    .HasColumnName("monthName")
                    .HasMaxLength(50);

                entity.Property(e => e.MonthNum).HasColumnName("monthNum");

                entity.Property(e => e.SettlementPeriod).HasColumnName("settlementPeriod");

                entity.Property(e => e.SummerWinter)
                    .IsRequired()
                    .HasColumnName("summerWinter")
                    .HasMaxLength(50);

                entity.Property(e => e.TimeOfDayLocal).HasColumnName("timeOfDayLocal");

                entity.Property(e => e.WeekNumber).HasColumnName("weekNumber");

                entity.Property(e => e.WorkingDay)
                    .IsRequired()
                    .HasColumnName("workingDay")
                    .HasMaxLength(50);

                entity.Property(e => e.Year).HasColumnName("year");
            });

            modelBuilder.Entity<DemandTrainSet0>(entity =>
            {
                entity.HasKey(e => e.DateTimeUtc);

                entity.ToTable("demand_train_set0");

                entity.Property(e => e.DateTimeUtc).HasColumnName("dateTimeUTC");

                entity.Property(e => e.RawDemandMw).HasColumnName("rawDemand_MW");
            });

            modelBuilder.Entity<DemandTrainSet1>(entity =>
            {
                entity.HasKey(e => e.Datetime);

                entity.ToTable("demand_train_set1");

                entity.Property(e => e.Datetime).HasColumnName("datetime");

                entity.Property(e => e.DemandMw).HasColumnName("demand_MW");
            });

            modelBuilder.Entity<DemandTrainSet2>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("demand_train_set2");

                entity.Property(e => e.Datetime).HasColumnName("datetime");

                entity.Property(e => e.DemandMw).HasColumnName("demand_MW");
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

            modelBuilder.Entity<PvTrainSet1>(entity =>
            {
                entity.HasKey(e => e.Datetime);

                entity.ToTable("pv_train_set1");

                entity.Property(e => e.Datetime).HasColumnName("datetime");

                entity.Property(e => e.IrradianceWm2).HasColumnName("irradiance_Wm_2");

                entity.Property(e => e.PanelTempC).HasColumnName("panel_temp_C");

                entity.Property(e => e.PvPowerMw).HasColumnName("pv_power_mw");
            });

            modelBuilder.Entity<PvTrainSet2>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("pv_train_set2");

                entity.Property(e => e.Datetime).HasColumnName("datetime");

                entity.Property(e => e.IrradianceWm2).HasColumnName("irradiance_Wm_2");

                entity.Property(e => e.PanelTempC).HasColumnName("panel_temp_C");

                entity.Property(e => e.PvPowerMw).HasColumnName("pv_power_mw");
            });

            modelBuilder.Entity<Task0ForecastCalendarMapWithForecastWeatherHh>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("task0ForecastCalendarMapWithForecastWeatherHH");

                entity.Property(e => e.BankHoliday)
                    .IsRequired()
                    .HasColumnName("bankHoliday")
                    .HasMaxLength(50);

                entity.Property(e => e.DateTimeLocal).HasColumnName("dateTimeLocal");

                entity.Property(e => e.DateTimeUtc).HasColumnName("dateTimeUTC");

                entity.Property(e => e.DayOfWeek)
                    .IsRequired()
                    .HasColumnName("dayOfWeek")
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.DayOfWeekNumber).HasColumnName("dayOfWeekNumber");

                entity.Property(e => e.HourNumber).HasColumnName("hourNumber");

                entity.Property(e => e.HourText)
                    .IsRequired()
                    .HasColumnName("hourText")
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.MonthName)
                    .IsRequired()
                    .HasColumnName("monthName")
                    .HasMaxLength(50);

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
                    .HasColumnName("summerWinter")
                    .HasMaxLength(50);

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
                    .HasColumnName("workingDay")
                    .HasMaxLength(50);

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
                    .HasColumnName("taskName")
                    .HasMaxLength(10)
                    .IsFixedLength();
            });

            modelBuilder.Entity<Task0TrainingCalWeatherHh>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("task0TrainingCalWeatherHH");

                entity.Property(e => e.BankHoliday)
                    .IsRequired()
                    .HasColumnName("bankHoliday")
                    .HasMaxLength(50);

                entity.Property(e => e.DateTimeLocal).HasColumnName("dateTimeLocal");

                entity.Property(e => e.DateTimeUtc).HasColumnName("dateTimeUTC");

                entity.Property(e => e.DayOfWeek)
                    .IsRequired()
                    .HasColumnName("dayOfWeek")
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.DayOfWeekNumber).HasColumnName("dayOfWeekNumber");

                entity.Property(e => e.HourNumber).HasColumnName("hourNumber");

                entity.Property(e => e.HourText)
                    .IsRequired()
                    .HasColumnName("hourText")
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.MonthName)
                    .IsRequired()
                    .HasColumnName("monthName")
                    .HasMaxLength(50);

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
                    .HasColumnName("summerWinter")
                    .HasMaxLength(50);

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
                    .HasColumnName("workingDay")
                    .HasMaxLength(50);

                entity.Property(e => e.Year).HasColumnName("year");
            });

            modelBuilder.Entity<Task0TrainingCalendarDemandWeatherHh>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("task0TrainingCalendarDemandWeatherHH");

                entity.Property(e => e.BankHoliday)
                    .IsRequired()
                    .HasColumnName("bankHoliday")
                    .HasMaxLength(50);

                entity.Property(e => e.DateTimeLocal).HasColumnName("dateTimeLocal");

                entity.Property(e => e.DateTimeUtc).HasColumnName("dateTimeUTC");

                entity.Property(e => e.DayOfWeek)
                    .IsRequired()
                    .HasColumnName("dayOfWeek")
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.DayOfWeekNumber).HasColumnName("dayOfWeekNumber");

                entity.Property(e => e.HourNumber).HasColumnName("hourNumber");

                entity.Property(e => e.HourText)
                    .IsRequired()
                    .HasColumnName("hourText")
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.MonthName)
                    .IsRequired()
                    .HasColumnName("monthName")
                    .HasMaxLength(50);

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
                    .HasColumnName("summerWinter")
                    .HasMaxLength(50);

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
                    .HasColumnName("workingDay")
                    .HasMaxLength(50);

                entity.Property(e => e.Year).HasColumnName("year");
            });

            modelBuilder.Entity<Task0TrainingCalendarMap>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("task0TrainingCalendarMap");

                entity.Property(e => e.BankHoliday)
                    .IsRequired()
                    .HasColumnName("bankHoliday")
                    .HasMaxLength(50);

                entity.Property(e => e.DateTimeLocal).HasColumnName("dateTimeLocal");

                entity.Property(e => e.DateTimeUtc).HasColumnName("dateTimeUTC");

                entity.Property(e => e.DayOfWeek)
                    .IsRequired()
                    .HasColumnName("dayOfWeek")
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.DayOfWeekNumber).HasColumnName("dayOfWeekNumber");

                entity.Property(e => e.HourNumber).HasColumnName("hourNumber");

                entity.Property(e => e.HourText)
                    .IsRequired()
                    .HasColumnName("hourText")
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.MonthName)
                    .IsRequired()
                    .HasColumnName("monthName")
                    .HasMaxLength(50);

                entity.Property(e => e.MonthNum).HasColumnName("monthNum");

                entity.Property(e => e.SettlementPeriod).HasColumnName("settlementPeriod");

                entity.Property(e => e.SummerWinter)
                    .IsRequired()
                    .HasColumnName("summerWinter")
                    .HasMaxLength(50);

                entity.Property(e => e.TimeOfDayLocal).HasColumnName("timeOfDayLocal");

                entity.Property(e => e.WeekNumber).HasColumnName("weekNumber");

                entity.Property(e => e.WorkingDay)
                    .IsRequired()
                    .HasColumnName("workingDay")
                    .HasMaxLength(50);

                entity.Property(e => e.Year).HasColumnName("year");
            });

            modelBuilder.Entity<Task0TrainingCalendarPvweatherHh>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("task0TrainingCalendarPVWeatherHH");

                entity.Property(e => e.BankHoliday)
                    .IsRequired()
                    .HasColumnName("bankHoliday")
                    .HasMaxLength(50);

                entity.Property(e => e.DateTimeLocal).HasColumnName("dateTimeLocal");

                entity.Property(e => e.DateTimeUtc).HasColumnName("dateTimeUTC");

                entity.Property(e => e.DayOfWeek)
                    .IsRequired()
                    .HasColumnName("dayOfWeek")
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.DayOfWeekNumber).HasColumnName("dayOfWeekNumber");

                entity.Property(e => e.HourNumber).HasColumnName("hourNumber");

                entity.Property(e => e.HourText)
                    .IsRequired()
                    .HasColumnName("hourText")
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.MonthName)
                    .IsRequired()
                    .HasColumnName("monthName")
                    .HasMaxLength(50);

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
                    .HasColumnName("summerWinter")
                    .HasMaxLength(50);

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
                    .HasColumnName("workingDay")
                    .HasMaxLength(50);

                entity.Property(e => e.Year).HasColumnName("year");
            });

            modelBuilder.Entity<Task0forecastCalendarMap>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("task0forecastCalendarMap");

                entity.Property(e => e.BankHoliday)
                    .IsRequired()
                    .HasColumnName("bankHoliday")
                    .HasMaxLength(50);

                entity.Property(e => e.DateTimeLocal).HasColumnName("dateTimeLocal");

                entity.Property(e => e.DateTimeUtc).HasColumnName("dateTimeUTC");

                entity.Property(e => e.DayOfWeek)
                    .IsRequired()
                    .HasColumnName("dayOfWeek")
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.DayOfWeekNumber).HasColumnName("dayOfWeekNumber");

                entity.Property(e => e.HourNumber).HasColumnName("hourNumber");

                entity.Property(e => e.HourText)
                    .IsRequired()
                    .HasColumnName("hourText")
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.MonthName)
                    .IsRequired()
                    .HasColumnName("monthName")
                    .HasMaxLength(50);

                entity.Property(e => e.MonthNum).HasColumnName("monthNum");

                entity.Property(e => e.SettlementPeriod).HasColumnName("settlementPeriod");

                entity.Property(e => e.SummerWinter)
                    .IsRequired()
                    .HasColumnName("summerWinter")
                    .HasMaxLength(50);

                entity.Property(e => e.TimeOfDayLocal).HasColumnName("timeOfDayLocal");

                entity.Property(e => e.WeekNumber).HasColumnName("weekNumber");

                entity.Property(e => e.WorkingDay)
                    .IsRequired()
                    .HasColumnName("workingDay")
                    .HasMaxLength(50);

                entity.Property(e => e.Year).HasColumnName("year");
            });

            modelBuilder.Entity<Task1ForecastCalendarMap>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("task1ForecastCalendarMap");

                entity.Property(e => e.BankHoliday)
                    .IsRequired()
                    .HasColumnName("bankHoliday")
                    .HasMaxLength(50);

                entity.Property(e => e.DateTimeLocal).HasColumnName("dateTimeLocal");

                entity.Property(e => e.DateTimeUtc).HasColumnName("dateTimeUTC");

                entity.Property(e => e.DayOfWeek)
                    .IsRequired()
                    .HasColumnName("dayOfWeek")
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.DayOfWeekNumber).HasColumnName("dayOfWeekNumber");

                entity.Property(e => e.HourNumber).HasColumnName("hourNumber");

                entity.Property(e => e.HourText)
                    .IsRequired()
                    .HasColumnName("hourText")
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.MonthName)
                    .IsRequired()
                    .HasColumnName("monthName")
                    .HasMaxLength(50);

                entity.Property(e => e.MonthNum).HasColumnName("monthNum");

                entity.Property(e => e.SettlementPeriod).HasColumnName("settlementPeriod");

                entity.Property(e => e.SummerWinter)
                    .IsRequired()
                    .HasColumnName("summerWinter")
                    .HasMaxLength(50);

                entity.Property(e => e.TimeOfDayLocal).HasColumnName("timeOfDayLocal");

                entity.Property(e => e.WeekNumber).HasColumnName("weekNumber");

                entity.Property(e => e.WorkingDay)
                    .IsRequired()
                    .HasColumnName("workingDay")
                    .HasMaxLength(50);

                entity.Property(e => e.Year).HasColumnName("year");
            });

            modelBuilder.Entity<Task1ForecastCalendarMapWithForecastWeatherHh>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("task1ForecastCalendarMapWithForecastWeatherHH");

                entity.Property(e => e.BankHoliday)
                    .IsRequired()
                    .HasColumnName("bankHoliday")
                    .HasMaxLength(50);

                entity.Property(e => e.DateTimeLocal).HasColumnName("dateTimeLocal");

                entity.Property(e => e.DateTimeUtc).HasColumnName("dateTimeUTC");

                entity.Property(e => e.DayOfWeek)
                    .IsRequired()
                    .HasColumnName("dayOfWeek")
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.DayOfWeekNumber).HasColumnName("dayOfWeekNumber");

                entity.Property(e => e.HourNumber).HasColumnName("hourNumber");

                entity.Property(e => e.HourText)
                    .IsRequired()
                    .HasColumnName("hourText")
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.MonthName)
                    .IsRequired()
                    .HasColumnName("monthName")
                    .HasMaxLength(50);

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
                    .HasColumnName("summerWinter")
                    .HasMaxLength(50);

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
                    .HasColumnName("workingDay")
                    .HasMaxLength(50);

                entity.Property(e => e.Year).HasColumnName("year");
            });

            modelBuilder.Entity<Task1ForecastsPvandDemandModelComparisons>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("task1ForecastsPVandDemand_ModelComparisons");

                entity.Property(e => e.DateTimeUtc).HasColumnName("dateTimeUTC");

                entity.Property(e => e.ForeDemandMwtask0Model).HasColumnName("foreDemandMWTask0Model");

                entity.Property(e => e.ForeDemandMwtask1Model).HasColumnName("foreDemandMWTask1Model");

                entity.Property(e => e.ForeDemandMwtask2Model).HasColumnName("foreDemandMWTask2Model");

                entity.Property(e => e.ForePvmwtask0Model).HasColumnName("forePVMWTask0Model");

                entity.Property(e => e.ForePvmwtask1Model).HasColumnName("forePVMWTask1Model");

                entity.Property(e => e.ForePvmwtask2Model).HasColumnName("forePVMWTask2Model");
            });

            modelBuilder.Entity<Task1ForecastsPvandDemandRun1>(entity =>
            {
                entity.HasKey(e => e.DateTimeUtc);

                entity.ToTable("task1ForecastsPVandDemand_Run1");

                entity.Property(e => e.DateTimeUtc).HasColumnName("dateTimeUTC");

                entity.Property(e => e.DemandMwnewModel).HasColumnName("demandMWNewModel");

                entity.Property(e => e.DemandMwoldModel).HasColumnName("demandMWOldModel");

                entity.Property(e => e.PvmwnewModel).HasColumnName("PVMWNewModel");

                entity.Property(e => e.PvmwnewModelCorrected).HasColumnName("PVMWNewModelCorrected");

                entity.Property(e => e.PvmwoldModel).HasColumnName("PVMWOldModel");
            });

            modelBuilder.Entity<Task1TrainingCalWeatherHh>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("task1TrainingCalWeatherHH");

                entity.Property(e => e.BankHoliday)
                    .IsRequired()
                    .HasColumnName("bankHoliday")
                    .HasMaxLength(50);

                entity.Property(e => e.DateTimeLocal).HasColumnName("dateTimeLocal");

                entity.Property(e => e.DateTimeUtc).HasColumnName("dateTimeUTC");

                entity.Property(e => e.DayOfWeek)
                    .IsRequired()
                    .HasColumnName("dayOfWeek")
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.DayOfWeekNumber).HasColumnName("dayOfWeekNumber");

                entity.Property(e => e.HourNumber).HasColumnName("hourNumber");

                entity.Property(e => e.HourText)
                    .IsRequired()
                    .HasColumnName("hourText")
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.MonthName)
                    .IsRequired()
                    .HasColumnName("monthName")
                    .HasMaxLength(50);

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
                    .HasColumnName("summerWinter")
                    .HasMaxLength(50);

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
                    .HasColumnName("workingDay")
                    .HasMaxLength(50);

                entity.Property(e => e.Year).HasColumnName("year");
            });

            modelBuilder.Entity<Task1TrainingCalendarDemandWeatherHh>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("task1TrainingCalendarDemandWeatherHH");

                entity.Property(e => e.BankHoliday)
                    .IsRequired()
                    .HasColumnName("bankHoliday")
                    .HasMaxLength(50);

                entity.Property(e => e.DateTimeLocal).HasColumnName("dateTimeLocal");

                entity.Property(e => e.DateTimeUtc).HasColumnName("dateTimeUTC");

                entity.Property(e => e.DayOfWeek)
                    .IsRequired()
                    .HasColumnName("dayOfWeek")
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.DayOfWeekNumber).HasColumnName("dayOfWeekNumber");

                entity.Property(e => e.DemandMw).HasColumnName("demand_mw");

                entity.Property(e => e.HourNumber).HasColumnName("hourNumber");

                entity.Property(e => e.HourText)
                    .IsRequired()
                    .HasColumnName("hourText")
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.MonthName)
                    .IsRequired()
                    .HasColumnName("monthName")
                    .HasMaxLength(50);

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
                    .HasColumnName("summerWinter")
                    .HasMaxLength(50);

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
                    .HasColumnName("workingDay")
                    .HasMaxLength(50);

                entity.Property(e => e.Year).HasColumnName("year");
            });

            modelBuilder.Entity<Task1TrainingCalendarMap>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("task1TrainingCalendarMap");

                entity.Property(e => e.BankHoliday)
                    .IsRequired()
                    .HasColumnName("bankHoliday")
                    .HasMaxLength(50);

                entity.Property(e => e.DateTimeLocal).HasColumnName("dateTimeLocal");

                entity.Property(e => e.DateTimeUtc).HasColumnName("dateTimeUTC");

                entity.Property(e => e.DayOfWeek)
                    .IsRequired()
                    .HasColumnName("dayOfWeek")
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.DayOfWeekNumber).HasColumnName("dayOfWeekNumber");

                entity.Property(e => e.HourNumber).HasColumnName("hourNumber");

                entity.Property(e => e.HourText)
                    .IsRequired()
                    .HasColumnName("hourText")
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.MonthName)
                    .IsRequired()
                    .HasColumnName("monthName")
                    .HasMaxLength(50);

                entity.Property(e => e.MonthNum).HasColumnName("monthNum");

                entity.Property(e => e.SettlementPeriod).HasColumnName("settlementPeriod");

                entity.Property(e => e.SummerWinter)
                    .IsRequired()
                    .HasColumnName("summerWinter")
                    .HasMaxLength(50);

                entity.Property(e => e.TimeOfDayLocal).HasColumnName("timeOfDayLocal");

                entity.Property(e => e.WeekNumber).HasColumnName("weekNumber");

                entity.Property(e => e.WorkingDay)
                    .IsRequired()
                    .HasColumnName("workingDay")
                    .HasMaxLength(50);

                entity.Property(e => e.Year).HasColumnName("year");
            });

            modelBuilder.Entity<Task1TrainingCalendarPvweatherHh>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("task1TrainingCalendarPVWeatherHH");

                entity.Property(e => e.BankHoliday)
                    .IsRequired()
                    .HasColumnName("bankHoliday")
                    .HasMaxLength(50);

                entity.Property(e => e.DateTimeLocal).HasColumnName("dateTimeLocal");

                entity.Property(e => e.DateTimeUtc).HasColumnName("dateTimeUTC");

                entity.Property(e => e.DayOfWeek)
                    .IsRequired()
                    .HasColumnName("dayOfWeek")
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.DayOfWeekNumber).HasColumnName("dayOfWeekNumber");

                entity.Property(e => e.HourNumber).HasColumnName("hourNumber");

                entity.Property(e => e.HourText)
                    .IsRequired()
                    .HasColumnName("hourText")
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.MonthName)
                    .IsRequired()
                    .HasColumnName("monthName")
                    .HasMaxLength(50);

                entity.Property(e => e.MonthNum).HasColumnName("monthNum");

                entity.Property(e => e.PvPowerMw).HasColumnName("pv_power_mw");

                entity.Property(e => e.SettlementPeriod).HasColumnName("settlementPeriod");

                entity.Property(e => e.SolarLocation1).HasColumnName("solar_location1");

                entity.Property(e => e.SolarLocation2).HasColumnName("solar_location2");

                entity.Property(e => e.SolarLocation3).HasColumnName("solar_location3");

                entity.Property(e => e.SolarLocation4).HasColumnName("solar_location4");

                entity.Property(e => e.SolarLocation5).HasColumnName("solar_location5");

                entity.Property(e => e.SolarLocation6).HasColumnName("solar_location6");

                entity.Property(e => e.SummerWinter)
                    .IsRequired()
                    .HasColumnName("summerWinter")
                    .HasMaxLength(50);

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
                    .HasColumnName("workingDay")
                    .HasMaxLength(50);

                entity.Property(e => e.Year).HasColumnName("year");
            });

            modelBuilder.Entity<Task2ForecastCalendarMap>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("task2ForecastCalendarMap");

                entity.Property(e => e.BankHoliday)
                    .IsRequired()
                    .HasColumnName("bankHoliday")
                    .HasMaxLength(50);

                entity.Property(e => e.DateTimeLocal).HasColumnName("dateTimeLocal");

                entity.Property(e => e.DateTimeUtc).HasColumnName("dateTimeUTC");

                entity.Property(e => e.DayOfWeek)
                    .IsRequired()
                    .HasColumnName("dayOfWeek")
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.DayOfWeekNumber).HasColumnName("dayOfWeekNumber");

                entity.Property(e => e.HourNumber).HasColumnName("hourNumber");

                entity.Property(e => e.HourText)
                    .IsRequired()
                    .HasColumnName("hourText")
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.MonthName)
                    .IsRequired()
                    .HasColumnName("monthName")
                    .HasMaxLength(50);

                entity.Property(e => e.MonthNum).HasColumnName("monthNum");

                entity.Property(e => e.SettlementPeriod).HasColumnName("settlementPeriod");

                entity.Property(e => e.SummerWinter)
                    .IsRequired()
                    .HasColumnName("summerWinter")
                    .HasMaxLength(50);

                entity.Property(e => e.TimeOfDayLocal).HasColumnName("timeOfDayLocal");

                entity.Property(e => e.WeekNumber).HasColumnName("weekNumber");

                entity.Property(e => e.WorkingDay)
                    .IsRequired()
                    .HasColumnName("workingDay")
                    .HasMaxLength(50);

                entity.Property(e => e.Year).HasColumnName("year");
            });

            modelBuilder.Entity<Task2ForecastCalendarMapWithForecastWeatherHh>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("task2ForecastCalendarMapWithForecastWeatherHH");

                entity.Property(e => e.BankHoliday)
                    .IsRequired()
                    .HasColumnName("bankHoliday")
                    .HasMaxLength(50);

                entity.Property(e => e.DateTimeLocal).HasColumnName("dateTimeLocal");

                entity.Property(e => e.DateTimeUtc).HasColumnName("dateTimeUTC");

                entity.Property(e => e.DayOfWeek)
                    .IsRequired()
                    .HasColumnName("dayOfWeek")
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.DayOfWeekNumber).HasColumnName("dayOfWeekNumber");

                entity.Property(e => e.HourNumber).HasColumnName("hourNumber");

                entity.Property(e => e.HourText)
                    .IsRequired()
                    .HasColumnName("hourText")
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.MonthName)
                    .IsRequired()
                    .HasColumnName("monthName")
                    .HasMaxLength(50);

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
                    .HasColumnName("summerWinter")
                    .HasMaxLength(50);

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
                    .HasColumnName("workingDay")
                    .HasMaxLength(50);

                entity.Property(e => e.Year).HasColumnName("year");
            });

            modelBuilder.Entity<Task2ForecastsPvandDemandRun1>(entity =>
            {
                entity.HasKey(e => e.DateTimeUtc);

                entity.ToTable("task2ForecastsPVandDemand_Run1");

                entity.Property(e => e.DateTimeUtc).HasColumnName("dateTimeUTC");

                entity.Property(e => e.DemandMwtask2).HasColumnName("demandMWtask2");

                entity.Property(e => e.Pvmwtask2)
                    .HasColumnName("PVMWtask2")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Task2ForecastsPvandDemandRun1OptimiseByHand20210228>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("task2ForecastsPVandDemand_Run1_OPTIMISE_BY_HAND_20210228");

                entity.Property(e => e.ChargeMw).HasColumnName("charge_MW");

                entity.Property(e => e.Datetime)
                    .HasColumnName("datetime")
                    .HasColumnType("datetime");

                entity.Property(e => e.K).HasColumnName("k");

                entity.Property(e => e.RunDateTime)
                    .HasColumnName("runDateTime")
                    .HasColumnType("datetime");

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

            modelBuilder.Entity<Task2ForecastsPvandDemandRun2OptimiseByHand20210302>(entity =>
            {
                entity.HasKey(e => e.Datetime);

                entity.ToTable("task2ForecastsPVandDemand_Run2_OPTIMISE_BY_HAND_20210302");

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

            modelBuilder.Entity<Task2TrainingCalWeatherHh>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("task2TrainingCalWeatherHH");

                entity.Property(e => e.BankHoliday)
                    .IsRequired()
                    .HasColumnName("bankHoliday")
                    .HasMaxLength(50);

                entity.Property(e => e.DateTimeLocal).HasColumnName("dateTimeLocal");

                entity.Property(e => e.DateTimeUtc).HasColumnName("dateTimeUTC");

                entity.Property(e => e.DayOfWeek)
                    .IsRequired()
                    .HasColumnName("dayOfWeek")
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.DayOfWeekNumber).HasColumnName("dayOfWeekNumber");

                entity.Property(e => e.HourNumber).HasColumnName("hourNumber");

                entity.Property(e => e.HourText)
                    .IsRequired()
                    .HasColumnName("hourText")
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.MonthName)
                    .IsRequired()
                    .HasColumnName("monthName")
                    .HasMaxLength(50);

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
                    .HasColumnName("summerWinter")
                    .HasMaxLength(50);

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
                    .HasColumnName("workingDay")
                    .HasMaxLength(50);

                entity.Property(e => e.Year).HasColumnName("year");
            });

            modelBuilder.Entity<Task2TrainingCalendarDemandWeatherHh>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("task2TrainingCalendarDemandWeatherHH");

                entity.Property(e => e.BankHoliday)
                    .IsRequired()
                    .HasColumnName("bankHoliday")
                    .HasMaxLength(50);

                entity.Property(e => e.DateTimeLocal).HasColumnName("dateTimeLocal");

                entity.Property(e => e.DateTimeUtc).HasColumnName("dateTimeUTC");

                entity.Property(e => e.DayOfWeek)
                    .IsRequired()
                    .HasColumnName("dayOfWeek")
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.DayOfWeekNumber).HasColumnName("dayOfWeekNumber");

                entity.Property(e => e.DemandMw).HasColumnName("demand_mw");

                entity.Property(e => e.HourNumber).HasColumnName("hourNumber");

                entity.Property(e => e.HourText)
                    .IsRequired()
                    .HasColumnName("hourText")
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.MonthName)
                    .IsRequired()
                    .HasColumnName("monthName")
                    .HasMaxLength(50);

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
                    .HasColumnName("summerWinter")
                    .HasMaxLength(50);

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
                    .HasColumnName("workingDay")
                    .HasMaxLength(50);

                entity.Property(e => e.Year).HasColumnName("year");
            });

            modelBuilder.Entity<Task2TrainingCalendarMap>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("task2TrainingCalendarMap");

                entity.Property(e => e.BankHoliday)
                    .IsRequired()
                    .HasColumnName("bankHoliday")
                    .HasMaxLength(50);

                entity.Property(e => e.DateTimeLocal).HasColumnName("dateTimeLocal");

                entity.Property(e => e.DateTimeUtc).HasColumnName("dateTimeUTC");

                entity.Property(e => e.DayOfWeek)
                    .IsRequired()
                    .HasColumnName("dayOfWeek")
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.DayOfWeekNumber).HasColumnName("dayOfWeekNumber");

                entity.Property(e => e.HourNumber).HasColumnName("hourNumber");

                entity.Property(e => e.HourText)
                    .IsRequired()
                    .HasColumnName("hourText")
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.MonthName)
                    .IsRequired()
                    .HasColumnName("monthName")
                    .HasMaxLength(50);

                entity.Property(e => e.MonthNum).HasColumnName("monthNum");

                entity.Property(e => e.SettlementPeriod).HasColumnName("settlementPeriod");

                entity.Property(e => e.SummerWinter)
                    .IsRequired()
                    .HasColumnName("summerWinter")
                    .HasMaxLength(50);

                entity.Property(e => e.TimeOfDayLocal).HasColumnName("timeOfDayLocal");

                entity.Property(e => e.WeekNumber).HasColumnName("weekNumber");

                entity.Property(e => e.WorkingDay)
                    .IsRequired()
                    .HasColumnName("workingDay")
                    .HasMaxLength(50);

                entity.Property(e => e.Year).HasColumnName("year");
            });

            modelBuilder.Entity<Task2TrainingCalendarPvweatherHh>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("task2TrainingCalendarPVWeatherHH");

                entity.Property(e => e.BankHoliday)
                    .IsRequired()
                    .HasColumnName("bankHoliday")
                    .HasMaxLength(50);

                entity.Property(e => e.DateTimeLocal).HasColumnName("dateTimeLocal");

                entity.Property(e => e.DateTimeUtc).HasColumnName("dateTimeUTC");

                entity.Property(e => e.DayOfWeek)
                    .IsRequired()
                    .HasColumnName("dayOfWeek")
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.DayOfWeekNumber).HasColumnName("dayOfWeekNumber");

                entity.Property(e => e.HourNumber).HasColumnName("hourNumber");

                entity.Property(e => e.HourText)
                    .IsRequired()
                    .HasColumnName("hourText")
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.MonthName)
                    .IsRequired()
                    .HasColumnName("monthName")
                    .HasMaxLength(50);

                entity.Property(e => e.MonthNum).HasColumnName("monthNum");

                entity.Property(e => e.PvPowerMw).HasColumnName("pv_power_mw");

                entity.Property(e => e.SettlementPeriod).HasColumnName("settlementPeriod");

                entity.Property(e => e.SolarLocation1).HasColumnName("solar_location1");

                entity.Property(e => e.SolarLocation2).HasColumnName("solar_location2");

                entity.Property(e => e.SolarLocation3).HasColumnName("solar_location3");

                entity.Property(e => e.SolarLocation4).HasColumnName("solar_location4");

                entity.Property(e => e.SolarLocation5).HasColumnName("solar_location5");

                entity.Property(e => e.SolarLocation6).HasColumnName("solar_location6");

                entity.Property(e => e.SummerWinter)
                    .IsRequired()
                    .HasColumnName("summerWinter")
                    .HasMaxLength(50);

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
                    .HasColumnName("workingDay")
                    .HasMaxLength(50);

                entity.Property(e => e.Year).HasColumnName("year");
            });

            modelBuilder.Entity<Tasks>(entity =>
            {
                entity.HasKey(e => e.TaskId)
                    .HasName("PK__Tasks__DD5D55A2988DB73E");

                entity.Property(e => e.TaskId).HasColumnName("taskID");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasColumnName("createdBy")
                    .HasMaxLength(255)
                    .HasDefaultValueSql("(user_name())");

                entity.Property(e => e.CreatedDate)
                    .HasColumnName("createdDate")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.FromDate)
                    .HasColumnName("fromDate")
                    .HasColumnType("date");

                entity.Property(e => e.TaskName)
                    .IsRequired()
                    .HasColumnName("taskName")
                    .HasMaxLength(50);

                entity.Property(e => e.ToDate)
                    .HasColumnName("toDate")
                    .HasColumnType("date");
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

            modelBuilder.Entity<WeatherTrainSet1>(entity =>
            {
                entity.HasKey(e => e.Datetime);

                entity.ToTable("weather_train_set1");

                entity.Property(e => e.Datetime).HasColumnName("datetime");

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

            modelBuilder.Entity<WeatherTrainSet1Hh>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("weather_train_set1_HH");

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

            modelBuilder.Entity<WeatherTrainSet2>(entity =>
            {
                entity.HasKey(e => e.Datetime);

                entity.ToTable("weather_train_set2");

                entity.Property(e => e.Datetime).HasColumnName("datetime");

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

            modelBuilder.Entity<WeatherTrainSet2Hh>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("weather_train_set2_HH");

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

            modelBuilder.Entity<_10forecastinputsByTask>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("10FORECASTInputsByTask");

                entity.Property(e => e.BankHoliday)
                    .IsRequired()
                    .HasColumnName("bankHoliday")
                    .HasMaxLength(50);

                entity.Property(e => e.DateTimeLocal).HasColumnName("dateTimeLocal");

                entity.Property(e => e.DateTimeUtc).HasColumnName("dateTimeUTC");

                entity.Property(e => e.DayOfWeek)
                    .IsRequired()
                    .HasColumnName("dayOfWeek")
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.DayOfWeekNumber).HasColumnName("dayOfWeekNumber");

                entity.Property(e => e.HourNumber).HasColumnName("hourNumber");

                entity.Property(e => e.HourText)
                    .IsRequired()
                    .HasColumnName("hourText")
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.MonthName)
                    .IsRequired()
                    .HasColumnName("monthName")
                    .HasMaxLength(50);

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
                    .HasColumnName("summerWinter")
                    .HasMaxLength(50);

                entity.Property(e => e.Task).HasColumnName("task");

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
                    .HasColumnName("workingDay")
                    .HasMaxLength(50);

                entity.Property(e => e.Year).HasColumnName("year");
            });

            modelBuilder.Entity<_20forecastoutputsByTaskRun>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("20FORECASTOutputsByTaskRun");

                entity.Property(e => e.DateTimeUtc).HasColumnName("dateTimeUTC");

                entity.Property(e => e.DemandForecastModelName).HasMaxLength(50);

                entity.Property(e => e.DemandModelGuid)
                    .HasColumnName("DemandModelGUID")
                    .HasMaxLength(50);

                entity.Property(e => e.ForecastDemandMw).HasColumnName("ForecastDemandMW");

                entity.Property(e => e.ForecastPv).HasColumnName("ForecastPV");

                entity.Property(e => e.PvforecastModelName)
                    .HasColumnName("PVForecastModelName")
                    .HasMaxLength(50);

                entity.Property(e => e.PvmodelGuid)
                    .HasColumnName("PVModelGUID")
                    .HasMaxLength(50);

                entity.Property(e => e.RunId).HasColumnName("runID");

                entity.Property(e => e.RunTimeStamp).HasColumnName("runTimeStamp");

                entity.Property(e => e.Task).HasColumnName("task");

                entity.Property(e => e.TaskName)
                    .HasColumnName("taskName")
                    .HasMaxLength(10)
                    .IsFixedLength();
            });

            modelBuilder.Entity<_21forecastoutputsByTaskRun>(entity =>
            {
                entity.ToTable("21FORECASTOutputsByTaskRun");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.DateTimeUtc).HasColumnName("dateTimeUTC");

                entity.Property(e => e.DemandForecastModelName).HasMaxLength(50);

                entity.Property(e => e.DemandModelGuid)
                    .HasColumnName("DemandModelGUID")
                    .HasMaxLength(50);

                entity.Property(e => e.ForecastDemandMw).HasColumnName("ForecastDemandMW");

                entity.Property(e => e.ForecastPv).HasColumnName("ForecastPV");

                entity.Property(e => e.PvforecastModelName)
                    .HasColumnName("PVForecastModelName")
                    .HasMaxLength(50);

                entity.Property(e => e.PvmodelGuid)
                    .HasColumnName("PVModelGUID")
                    .HasMaxLength(50);

                entity.Property(e => e.RunId).HasColumnName("runID");

                entity.Property(e => e.RunTimeStamp).HasColumnName("runTimeStamp");

                entity.Property(e => e.Task).HasColumnName("task");

                entity.Property(e => e.TaskName)
                    .HasColumnName("taskName")
                    .HasMaxLength(10)
                    .IsFixedLength();
            });

            modelBuilder.Entity<_30resultsoptimisation>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("30RESULTSOptimisation");

                entity.Property(e => e.ChargeMw).HasColumnName("charge_MW");

                entity.Property(e => e.D).HasMaxLength(50);

                entity.Property(e => e.Datetime).HasColumnName("datetime");

                entity.Property(e => e.K)
                    .HasColumnName("k")
                    .HasMaxLength(50);

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

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
