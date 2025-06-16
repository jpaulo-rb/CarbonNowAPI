using AutoMapper;
using CarbonNowAPI.Model;
using CarbonNowAPI.ViewModel.Usuario;

namespace CarbonNowAPI.Utils {
    public class MappingConfig : Profile {

        public MappingConfig() {
            CreateMap<Usuario, UsuarioExibicaoViewModel>();
            CreateMap<UsuarioCadastroViewModel, Usuario>();
            CreateMap<UsuarioAlteracaoViewModel, Usuario>();
            CreateMap<UsuarioLoginViewModel, Usuario>();
        }
    }
}
