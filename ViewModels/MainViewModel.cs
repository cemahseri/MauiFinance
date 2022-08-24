using MauiFinance.Models;

namespace MauiFinance.ViewModels;

public class MainViewModel
{
    public string ProfilePhotoSource { get; set; } = "cemahseri";
    public string ProfileName { get; set; } = "cemahseri";
    public string ProfileDetails { get; set; } = "Back-End Developer";

    public int Income { get; set; } = 8900;
    public int Expenses { get; set; } = 5500;
    public int Loan { get; set; } = 890;

    public List<OverviewItem> OverviewItems { get; set; } = new List<OverviewItem>
    {
        new OverviewItem
        {
            IconSource = "arrow_upward",

            Title = "Sent",
            Details = "Sent payment to client.",

            Amount = 150
        },
        new OverviewItem
        {
            IconSource = "arrow_downward",

            Title = "Receive",
            Details = "Received payment from company.",

            Amount = 200
        },
        new OverviewItem
        {
            IconSource = "payments",

            Title = "Loan",
            Details = "Loan for the car.",

            Amount = 100
        },
        new OverviewItem
        {
            IconSource = "arrow_upward",

            Title = "Sent",
            Details = "Sent payment to client.",

            Amount = 150
        },
        new OverviewItem
        {
            IconSource = "arrow_downward",

            Title = "Receive",
            Details = "Received payment from company.",

            Amount = 306
        }
    };
}