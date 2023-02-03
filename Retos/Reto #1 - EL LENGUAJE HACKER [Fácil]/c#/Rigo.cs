using System.Text;

Dictionary<char, string> dic = new Dictionary<char, string>
{
    {'a',"4"},{'b',"I3"},{'c',"["},{'d',")"},{'e',"3"},{'f',"|="},{'g',"&"},{'h',"#"},
    {'i',"1"},{'j',",_|"},{'k',">|"},{'l',"1"},
    {'m',@"/\/\"},{'n',"^/"},{'o',"0"},{'p',"|*"},{'q',"(_,)"},{'r',"I2"},{'s',"5"},{'t',"7"},
    {'u',"(_)"},{'v',@"\/"},{'w',@"\/\/"},{'x',"><"},{'y',"j"},{'z',"2"}
};


var txt_norm = "hola mundo";
var texto = txt_norm.Split(" ");

var txt_hack = new StringBuilder("");

foreach (var palabra in texto)
{
    var palabra_hack = new StringBuilder("");
    foreach (var c in palabra)
    {
        palabra_hack.Append(dic[c]);
    }

    palabra_hack.Append(" ");
    txt_hack.Append(palabra_hack);
}

Console.WriteLine(txt_hack);
