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
            //.ProjectUsing(src => new DomainClasses.Entities.Cheque
            //{
            //    BranchCode = src.BranchCode,
            //    Id = src.Id,
            //    BankId = src.BankId,
            //    AccountOwner = src.AccountOwner,
            //    CreatedOn = src.CreatedOn.ToGeorgeDateTime(),
            //    CodeNumber = src.CodeNumber,
            //    AccountNumber = src.AccountNumber,
            //    AssignmentedOn = src.AssignmentedOn.ToGeorgeDateTime(),
            //    AssignorName = src.AssignorName,
            //    CityId = src.CityId,
            //    CostValue = src.CostValue,
            //    CustomerName = src.CustomerName,
            //    DeliveredOn = src.DeliveredOn.ToGeorgeDateTime(),
            //    ReceiptedOn = src.ReceiptedOn.ToGeorgeDateTime(),
            //    ReceivedOn = src.ReceivedOn.ToGeorgeDateTime(),
            //    ReturnedOn = src.ReturnedOn.ToGeorgeDateTime(),
            //    SerialNumber = src.SerialNumber,
            //    SettlementDay = src.SettlementDay.ToGeorgeDateTime(),
            //    SettlementedOn = src.SettlementedOn.ToGeorgeDateTime(),
            //    SpentTo = src.SpentTo,
            //    StatusId = src.StatusId,
            //    TrackingNumber = src.TrackingNumber
            //});
            .ForMember(dest => dest.ReceiptedOn, opts => opts.MapFrom(src => src.ReceiptedOn.ToGeorgeDateTime()))
                .ForMember(dest => dest.ReceivedOn, opts => opts.MapFrom(src => src.ReceivedOn.ToGeorgeDateTime()))
                .ForMember(dest => dest.ReturnedOn, opts => opts.MapFrom(src => src.ReturnedOn.ToGeorgeDateTime()))
                .ForMember(dest => dest.SerialNumber, opts => opts.MapFrom(src => src.SerialNumber))
                .ForMember(dest => dest.SettlementDay,
                    opts => opts.MapFrom(src => src.SettlementDay.ToGeorgeDateTime()))
                .ForMember(dest => dest.SettlementedOn,
                    opts => opts.MapFrom(src => src.SettlementedOn.ToGeorgeDateTime()))
                .ForMember(dest => dest.SpentTo, opts => opts.MapFrom(src => src.SpentTo))
                .ForMember(dest => dest.StatusId, opts => opts.MapFrom(src => src.StatusId))
                .ForMember(dest => dest.TrackingNumber, opts => opts.MapFrom(src => src.TrackingNumber))
                .ForMember(dest => dest.BranchCode, opts => opts.MapFrom(src => src.BranchCode))
                .ForMember(dest => dest.AccountNumber, opts => opts.MapFrom(src => src.AccountNumber))
                .ForMember(dest => dest.AccountOwner, opts => opts.MapFrom(src => src.AccountOwner))
                .ForMember(dest => dest.AssignmentedOn,
                    opts => opts.MapFrom(src => src.AssignmentedOn.ToGeorgeDateTime()))
                .ForMember(dest => dest.AssignorName, opts => opts.MapFrom(src => src.AssignorName))
                .ForMember(dest => dest.BankId, opts => opts.MapFrom(src => src.BankId))
                .ForMember(dest => dest.CityId, opts => opts.MapFrom(src => src.CityId))
                .ForMember(dest => dest.CodeNumber, opts => opts.MapFrom(src => src.CodeNumber))
                .ForMember(dest => dest.CostValue, opts => opts.MapFrom(src => src.CostValue))
                .ForMember(dest => dest.CustomerName, opts => opts.MapFrom(src => src.CustomerName))
                .ForMember(dest => dest.Id, opts => opts.MapFrom(src => src.Id))
                .ForMember(dest => dest.CreatedOn, opts => opts.MapFrom(src => src.CreatedOn.ToGeorgeDateTime()))
                .ForMember(dest => dest.DeliveredOn, opts => opts.MapFrom(src => src.DeliveredOn.ToGeorgeDateTime()))
                .ForAllOtherMembers(opt => opt.Ignore());
        }}
}