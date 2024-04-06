using System.Xml.Linq;
using System.Text.Json;

namespace WinForm_Task_2;

public class User
{
    public string _name{ get; set; }

    public string _surname { get; set; }

    public string  _phone { get; set; }
    public string _peshe{ get; set; }

    public string _city { get; set; }

    public string _country { get; set; }

    public DateTime il{ get; set; }

    public string _cins { get; set; }
    public User()
    {
        
    }
    public User(string name,string surname,string phone,string pehse,string city,string counttry,DateTime yas,string cins)
    {
        _name = name;
        _surname = surname;
        _peshe = pehse;
        _phone = phone;
        _city = city;
        _country = counttry;
        il = yas;
        _cins = cins;
    }
    public override string ToString()
    {
        return $"{_name}\n{_surname}\n{_phone}\n{_peshe}\n{_city}\n{_country}\n{il}\n{_cins}";
    }

    
}
