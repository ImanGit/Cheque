using AutoMapper;
using Cheque.Mapping.Extensions;
using Cheque.ViewModel.Models;

namespace Cheque.Mapping.Profiles
{
    /// <summary>
    /// </summary>
    public class ChequeProfile : Profile
    {
        /// <summary>
        /// </summary>
        public ChequeProfile()
        {
            CreateMap<DomainClasses.Entities.Cheque, ChequeViewModel>()
                .ProjectUsing(src => new ChequeViewModel
                {
                    BranchCode = src.BranchCode,
                    Id = src.Id,
                    BankId = src.BankId,
                    AccountOwner = src.AccountOwner,
                    CreatedOn = src.CreatedOn.ToPersianDateTime(),
                    CodeNumber = src.CodeNumber,
                    AccountNumber = src.AccountNumber,
                    AssignmentedOn = src.AssignmentedOn.ToPersianDateTime(),
                    AssignorName = src.AssignorName,
                    CityId = src.CityId,
                    CostValue = src.CostValue,
                    CustomerName = src.CustomerName,
                    DeliveredOn = src.DeliveredOn.ToPersianDateTime(),
                    ReceiptedOn = src.ReceiptedOn.ToPersianDateTime(),
                    ReceivedOn = src.ReceivedOn.ToPersianDateTime(),
                    ReturnedOn = src.ReturnedOn.ToPersianDateTime(),
                    SerialNumber = src.SerialNumber,
                    SettlementDay = src.SettlementDay.ToPersianDateTime(),
                    SettlementedOn = src.SettlementedOn.ToPersianDateTime(),
                    SpentTo = src.SpentTo,
                    StatusId = src.StatusId,
                    TrackingNumber = src.TrackingNumber
                });

            CreateMap<ChequeViewModel, DomainClasses.Entities.Cheque>()
                .ForMember(dest => dest.ReceiptedOn.ToPersianDateTime(), opts => opts.MapFrom(src => src.ReceiptedOn))
                .ForMember(dest => dest.ReceivedOn.ToPersianDateTime(), opts => opts.MapFrom(src => src.ReceivedOn))
                .ForMember(dest => dest.ReturnedOn.ToPersianDateTime(), opts => opts.MapFrom(src => src.ReturnedOn))
                .ForMember(dest => dest.SerialNumber, opts => opts.MapFrom(src => src.SerialNumber))
                .ForMember(dest => dest.SettlementDay.ToPersianDateTime(),
                    opts => opts.MapFrom(src => src.SettlementDay))
                .ForMember(dest => dest.SettlementedOn.ToPersianDateTime(),
                    opts => opts.MapFrom(src => src.SettlementedOn))
                .ForMember(dest => dest.SpentTo, opts => opts.MapFrom(src => src.SpentTo))
                .ForMember(dest => dest.StatusId, opts => opts.MapFrom(src => src.StatusId))
                .ForMember(dest => dest.TrackingNumber, opts => opts.MapFrom(src => src.TrackingNumber))
                .ForMember(dest => dest.BranchCode, opts => opts.MapFrom(src => src.BranchCode))
                .ForMember(dest => dest.AccountNumber, opts => opts.MapFrom(src => src.AccountNumber))
                .ForMember(dest => dest.AccountOwner, opts => opts.MapFrom(src => src.AccountOwner))
                .ForMember(dest => dest.AssignmentedOn.ToPersianDateTime(),
                    opts => opts.MapFrom(src => src.AssignmentedOn))
                .ForMember(dest => dest.AssignorName, opts => opts.MapFrom(src => src.AssignorName))
                .ForMember(dest => dest.BankId, opts => opts.MapFrom(src => src.BankId))
                .ForMember(dest => dest.CityId, opts => opts.MapFrom(src => src.CityId))
                .ForMember(dest => dest.CodeNumber, opts => opts.MapFrom(src => src.CodeNumber))
                .ForMember(dest => dest.CostValue, opts => opts.MapFrom(src => src.CostValue))
                .ForMember(dest => dest.CustomerName, opts => opts.MapFrom(src => src.CustomerName))
                .ForMember(dest => dest.Id, opts => opts.MapFrom(src => src.Id))
                .ForMember(dest => dest.CreatedOn.ToPersianDateTime(), opts => opts.MapFrom(src => src.CreatedOn))
                .ForMember(dest => dest.DeliveredOn.ToPersianDateTime(), opts => opts.MapFrom(src => src.DeliveredOn))
                .ForAllOtherMembers(opt => opt.Ignore());
        }
    }
}