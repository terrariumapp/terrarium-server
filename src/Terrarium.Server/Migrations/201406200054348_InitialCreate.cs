using System.Data.Entity.Migrations;

namespace Terrarium.Server.Migrations
{
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.RandomTips",
                c => new
                {
                    Id = c.Int(false, true),
                    Tip = c.String(false, 512),
                })
                .PrimaryKey(t => t.Id);

            CreateTable(
                "dbo.Usage",
                c => new
                {
                    Id = c.Int(false, true),
                    Alias = c.String(false, 255),
                    Domain = c.String(false, 255),
                    TickTime = c.DateTime(false),
                    UsageMinutes = c.Int(false),
                    IPAddress = c.String(false, 25),
                    GameVersion = c.String(false, 255),
                    PeerChannel = c.String(false, 255),
                    PeerCount = c.Int(false),
                    AnimalCount = c.Int(false),
                    MaxAnimalCount = c.Int(false),
                    WorldHeight = c.Int(false),
                    WorldWidth = c.Int(false),
                    MachineName = c.String(false, 255),
                    OSVersion = c.String(false, 255),
                    ProcessorCount = c.Int(false),
                    ClrVersion = c.String(false, 255),
                    WorkingSet = c.Int(false),
                    MaxWorkingSet = c.Int(false),
                    MinWorkingSet = c.Int(false),
                    ProcessorTime = c.Int(false),
                    ProcessStarTime = c.DateTime(false),
                })
                .PrimaryKey(t => t.Id);

            CreateTable(
                "dbo.DailyPopulation",
                c => new
                {
                    Id = c.Int(false, true),
                    SampleDateTime = c.DateTime(false),
                    SpeciesName = c.String(false, 255),
                    Population = c.Int(false),
                    BirthCount = c.Int(false),
                    StarvedCount = c.Int(false),
                    KilledCount = c.Int(false),
                    ErrorCount = c.Int(false),
                    TimeoutCount = c.Int(false),
                    SickCount = c.Int(false),
                    OldAgeCount = c.Int(false),
                    SecurityViolationCount = c.Int(false),
                })
                .PrimaryKey(t => t.Id);

            CreateTable(
                "dbo.Downloads",
                c => new
                {
                    Id = c.Int(false, true),
                    Filename = c.String(false, 255),
                    DownloadCount = c.Int(false),
                    LastDownloadDate = c.DateTime(false),
                })
                .PrimaryKey(t => t.Id);

            CreateTable(
                "dbo.History",
                c => new
                {
                    Id = c.Int(false, true),
                    GUID = c.Guid(false),
                    TickNumber = c.Int(false),
                    SpeciesName = c.String(false, 255),
                    ContactTime = c.DateTime(false),
                    ClientTime = c.DateTime(false),
                    CorrectTime = c.Int(false),
                    Population = c.Int(false),
                    BirthCount = c.Int(false),
                    TeleportedToCount = c.Int(false),
                    StarvedCount = c.Int(false),
                    KilledCount = c.Int(false),
                    TeleportedFromCount = c.Int(false),
                    ErrorCount = c.Int(false),
                    TimeoutCount = c.Int(false),
                    SickCount = c.Int(false),
                    OldAgeCount = c.Int(false),
                    SecurityViolationCount = c.Int(false),
                })
                .PrimaryKey(t => t.Id);

            CreateTable(
                "dbo.NodeLastContact",
                c => new
                {
                    Id = c.Int(false, true),
                    GUID = c.Guid(false),
                    LastTick = c.Int(false),
                    LastContact = c.DateTime(false),
                })
                .PrimaryKey(t => t.Id);

            CreateTable(
                "dbo.Peers",
                c => new
                {
                    Id = c.Int(false, true),
                    Lease = c.DateTime(false),
                    Guid = c.Guid(false),
                    Channel = c.String(false, 32),
                    IPAddress = c.String(false, 16),
                    Version = c.String(false, 16),
                    FirstContact = c.DateTime(false),
                })
                .PrimaryKey(t => t.Id);

            CreateTable(
                "dbo.ShutdownPeers",
                c => new
                {
                    Id = c.Int(false, true),
                    LastContact = c.DateTime(false),
                    UnRegister = c.Boolean(false),
                    Guid = c.Guid(false),
                    Channel = c.String(false, 255),
                    IPAddress = c.String(false, 50),
                    Version = c.String(false, 255),
                    FirstContact = c.DateTime(false),
                })
                .PrimaryKey(t => t.Id);

            CreateTable(
                "dbo.Species",
                c => new
                {
                    Id = c.Int(false, true),
                    Name = c.String(false, 255),
                    Type = c.String(false, 50),
                    Author = c.String(false, 255),
                    AuthorEmail = c.String(false, 255),
                    DateAdded = c.DateTime(false),
                    AssemblyFullName = c.String(false),
                    Extinct = c.Int(false),
                    LastReintroduction = c.DateTime(false),
                    ReintroductionNode = c.Guid(false),
                    Version = c.String(false, 255),
                    BlackListed = c.Boolean(false),
                    ExtinctDate = c.DateTime(false),
                })
                .PrimaryKey(t => t.Id);

            CreateTable(
                "dbo.TimedOutNodes",
                c => new
                {
                    Id = c.Int(false, true),
                    GUID = c.Guid(false),
                    TimeoutDate = c.DateTime(false),
                })
                .PrimaryKey(t => t.Id);

            CreateTable(
                "dbo.UsageSummary",
                c => new
                {
                    Id = c.Int(false, true),
                    Peers = c.Int(false),
                    SummaryDateTime = c.DateTime(false),
                })
                .PrimaryKey(t => t.Id);

            CreateTable(
                "dbo.UserRegister",
                c => new
                {
                    Id = c.Int(false, true),
                    IPAddress = c.String(false, 50),
                    Email = c.String(maxLength: 255),
                })
                .PrimaryKey(t => t.Id);

            CreateTable(
                "dbo.VersionedSettings",
                c => new
                {
                    Id = c.Int(false, true),
                    Version = c.String(false, 255),
                    Disabled = c.Int(false),
                    Message = c.String(maxLength: 255),
                })
                .PrimaryKey(t => t.Id);

            CreateTable(
                "dbo.Watson",
                c => new
                {
                    Id = c.Int(false, true),
                    LogType = c.String(maxLength: 50),
                    MachineName = c.String(maxLength: 255),
                    OSVersion = c.String(maxLength: 50),
                    GameVersion = c.String(maxLength: 50),
                    CLRVersion = c.String(maxLength: 50),
                    ErrorLog = c.String(),
                    UserEmail = c.String(maxLength: 255),
                    UserComment = c.String(),
                    DateSubmitted = c.DateTime(false),
                })
                .PrimaryKey(t => t.Id);
        }

        public override void Down()
        {
            DropTable("dbo.Watson");
            DropTable("dbo.VersionedSettings");
            DropTable("dbo.UserRegister");
            DropTable("dbo.UsageSummary");
            DropTable("dbo.TimedOutNodes");
            DropTable("dbo.Species");
            DropTable("dbo.ShutdownPeers");
            DropTable("dbo.Peers");
            DropTable("dbo.NodeLastContact");
            DropTable("dbo.History");
            DropTable("dbo.Downloads");
            DropTable("dbo.DailyPopulation");
            DropTable("dbo.Usage");
            DropTable("dbo.RandomTips");
        }
    }
}