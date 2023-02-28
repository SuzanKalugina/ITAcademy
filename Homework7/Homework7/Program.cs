using Task1;

var guitar1 = new Guitar ( 3, "коричневый", 6, "левостороннее" );
var guitar2 = new Guitar(5, "белый", 7, "правостороннее");
var synthesizer1 = new Synthesizer(7, "черный", 61, 120 );
var synthesizer2 = new Synthesizer(6, "желтый", 37, 8);
var violin1 = new Violin(1, "бежевый", "липа", "4/4");
var violin2 = new Violin(2, "черный", "клен", "1/4");

IPlayable[] musicalInstrument = { guitar1, guitar2, violin1, violin2, synthesizer1, synthesizer2 };

foreach (var item in musicalInstrument)
{
    item.Play();
}

