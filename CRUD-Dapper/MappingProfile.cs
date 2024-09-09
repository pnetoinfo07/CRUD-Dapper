using AutoMapper;
using CRUD_Dapper.DTOs.Produto;

namespace CRUD_Dapper
{
    public class MappingProfile:Profile
    {
        public MappingProfile()
        {
            CreateMap<CreateProdutoDTO, Produto>();
        }
    }
}
