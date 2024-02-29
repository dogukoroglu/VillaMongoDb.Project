using AutoMapper;
using Villa.Dto.Dtos.BannerDto;
using Villa.Dto.Dtos.ContactDto;
using Villa.Dto.Dtos.CounterDto;
using Villa.Dto.Dtos.DealDto;
using Villa.Dto.Dtos.FeatureDto;
using Villa.Dto.Dtos.MessageDto;
using Villa.Dto.Dtos.ProductDto;
using Villa.Dto.Dtos.QuestDto;
using Villa.Dto.Dtos.VideoDto;
using Villa.Entity.Entities;

namespace Villa.WebUI.Mapping
{
	public class GeneralMapping : Profile
	{
		public GeneralMapping()
		{
			CreateMap<ResultBannerDto, Banner>().ReverseMap();
			CreateMap<UpdateBannerDto, Banner>().ReverseMap();
			CreateMap<CreateBannerDto, Banner>().ReverseMap();

			CreateMap<ResultContactDto, Contact>().ReverseMap();
			CreateMap<UpdateContactDto, Contact>().ReverseMap();
			CreateMap<CreateContactDto, Contact>().ReverseMap();

			CreateMap<ResultCounterDto, Counter>().ReverseMap();
			CreateMap<UpdateCounterDto, Counter>().ReverseMap();
			CreateMap<CreateCounterDto, Counter>().ReverseMap();

			CreateMap<ResultDealDto, Deal>().ReverseMap();
			CreateMap<UpdateDealDto, Deal>().ReverseMap();
			CreateMap<CreateDealDto, Deal>().ReverseMap();

			CreateMap<ResultFeatureDto, Feature>().ReverseMap();
			CreateMap<UpdateFeatureDto, Feature>().ReverseMap();
			CreateMap<CreateFeatureDto, Feature>().ReverseMap();

			CreateMap<ResultMessageDto, Message>().ReverseMap();
			CreateMap<UpdateMessageDto, Message>().ReverseMap();
			CreateMap<CreateMessageDto, Message>().ReverseMap();

			CreateMap<ResultProductDto, Product>().ReverseMap();
			CreateMap<UpdateProductDto, Product>().ReverseMap();
			CreateMap<CreateProductDto, Product>().ReverseMap();

			CreateMap<ResultQuestDto, Quest>().ReverseMap();
			CreateMap<UpdateQuestDto, Quest>().ReverseMap();
			CreateMap<CreateQuestDto, Quest>().ReverseMap();

			CreateMap<ResultVideoDto, Video>().ReverseMap();
			CreateMap<UpdateVideoDto, Video>().ReverseMap();
			CreateMap<CreateVideoDto, Video>().ReverseMap();

		}
	}
}
