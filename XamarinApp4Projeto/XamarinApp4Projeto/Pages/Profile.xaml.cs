using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinApp4Projeto.Models;

namespace XamarinApp4Projeto.Pages
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Profile : ContentPage
	{
	    private int _idProfile;
	    private ProfileModel _profileModel;

		public Profile(int idProdile)
		{
		    _idProfile = idProdile;
            InitializeComponent();
		    SetProfile();
        }

	    private void SetProfile()
	    {
	        switch (_idProfile)
	        {
                case 2:
                    _profileModel = new ProfileModel()
                    {
                        Nome = "Joseph Hill",
                        Idade = 28,
                        DataNascimento = new DateTime(1990, 05, 25),
                        Texto = @"Joseph Hill..."
                    };
                break;
	            case 3:
	                _profileModel = new ProfileModel()
	                {
	                    Nome = "Nat Friedman",
	                    Idade = 25,
	                    DataNascimento = new DateTime(1993, 03, 11),
	                    Texto = @"Nat Friedman..."
                    };
	            break;
	            default:
	                _profileModel = new ProfileModel()
	                {
	                    Nome = "Miguel de Icaza",
	                    Idade = 18,
	                    DataNascimento = new DateTime(2000, 01, 10),
	                    Texto = @"Miguel de Icaza nasceu na Cidade do México e estudou na Universidade Nacional Autônoma do México UNAM. Ele começou a escrever softwares em 1992.

Icaza começou o projeto GNOME em agosto de 1997. Ele e Federico Mena..."
	                };
	            break;
            }

	        ImageAvatar.Source = "avatar_"+_idProfile.ToString()+".png";
	        LabelNome.Text = _profileModel.Nome;
	        LabelIdade.Text = _profileModel.Idade.ToString();
	        LabelDataNascimento.Text = String.Format(
	            "{0}/{1}/{2}", 
	            ((_profileModel.DataNascimento.Day < 10) ? "0"+_profileModel.DataNascimento.Day.ToString(): _profileModel.DataNascimento.Day.ToString()),
	            ((_profileModel.DataNascimento.Month < 10) ? "0" + _profileModel.DataNascimento.Month.ToString() : _profileModel.DataNascimento.Month.ToString()), 
	            _profileModel.DataNascimento.Year
	        );
	        TextoProfileName.Text = _profileModel.Texto;
	    }
	}
}