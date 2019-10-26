using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace QOTD.WebApi.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categoria",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nombre = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categoria", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Frase",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Texto = table.Column<string>(nullable: true),
                    Autor = table.Column<string>(nullable: true),
                    Fecha = table.Column<DateTime>(nullable: false),
                    CategoriaId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Frase", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Frase_Categoria_CategoriaId",
                        column: x => x.CategoriaId,
                        principalTable: "Categoria",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Categoria",
                columns: new[] { "Id", "Nombre" },
                values: new object[] { 1, "Tecnologia" });

            migrationBuilder.InsertData(
                table: "Categoria",
                columns: new[] { "Id", "Nombre" },
                values: new object[] { 2, "Ciencia" });

            migrationBuilder.InsertData(
                table: "Categoria",
                columns: new[] { "Id", "Nombre" },
                values: new object[] { 3, "Fisica" });

            migrationBuilder.InsertData(
                table: "Frase",
                columns: new[] { "Id", "Autor", "CategoriaId", "Fecha", "Texto" },
                values: new object[] { 1, "Sir Arthur C. Clarke.", 1, new DateTime(2019, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Cualquier tecnología suficientemente avanzada es equivalente a la magia." });

            migrationBuilder.InsertData(
                table: "Frase",
                columns: new[] { "Id", "Autor", "CategoriaId", "Fecha", "Texto" },
                values: new object[] { 256, "Albert Einstein.", 2, new DateTime(2019, 9, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Una fe estúpida en la autoridad es el peor enemigo de la verdad." });

            migrationBuilder.InsertData(
                table: "Frase",
                columns: new[] { "Id", "Autor", "CategoriaId", "Fecha", "Texto" },
                values: new object[] { 255, "Carl Sagan.", 2, new DateTime(2019, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "La extinción es una regla. La supervivencia es la excepción." });

            migrationBuilder.InsertData(
                table: "Frase",
                columns: new[] { "Id", "Autor", "CategoriaId", "Fecha", "Texto" },
                values: new object[] { 254, "Isaac Newton.", 2, new DateTime(2019, 9, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "La gravedad explica los movimientos de los planetas, pero no puede explicar qué los pone en movimiento." });

            migrationBuilder.InsertData(
                table: "Frase",
                columns: new[] { "Id", "Autor", "CategoriaId", "Fecha", "Texto" },
                values: new object[] { 253, "Madeleine L’Engle.", 2, new DateTime(2019, 9, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Una línea recta no es la distancia más corta entre dos puntos." });

            migrationBuilder.InsertData(
                table: "Frase",
                columns: new[] { "Id", "Autor", "CategoriaId", "Fecha", "Texto" },
                values: new object[] { 252, "Arthur C. Clarke.", 2, new DateTime(2019, 9, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "La magia es solo una ciencia que no entendemos todavía." });

            migrationBuilder.InsertData(
                table: "Frase",
                columns: new[] { "Id", "Autor", "CategoriaId", "Fecha", "Texto" },
                values: new object[] { 251, "Elon Musk.", 2, new DateTime(2019, 9, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Marte es el único planeta del sistema solar donde es posible que la vida se multiplique." });

            migrationBuilder.InsertData(
                table: "Frase",
                columns: new[] { "Id", "Autor", "CategoriaId", "Fecha", "Texto" },
                values: new object[] { 250, "Bill Nye.", 2, new DateTime(2019, 9, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "La ciencia es la llave a nuestro futuro y si no crees en ella, entonces estas reteniendo a todos." });

            migrationBuilder.InsertData(
                table: "Frase",
                columns: new[] { "Id", "Autor", "CategoriaId", "Fecha", "Texto" },
                values: new object[] { 249, "Alan Turing.", 2, new DateTime(2019, 9, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "La ciencia es una ecuación diferencial. La religión solo es una condición de frontera." });

            migrationBuilder.InsertData(
                table: "Frase",
                columns: new[] { "Id", "Autor", "CategoriaId", "Fecha", "Texto" },
                values: new object[] { 248, "Emily Post.", 2, new DateTime(2019, 9, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Nada es menos importante que la forma en que usas un tenedor. La etiqueta es la ciencia del vivir. Lo es todo. Es ética. Es honor." });

            migrationBuilder.InsertData(
                table: "Frase",
                columns: new[] { "Id", "Autor", "CategoriaId", "Fecha", "Texto" },
                values: new object[] { 247, "Aleister Crowley.", 2, new DateTime(2019, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "La ciencia siempre está descubriendo extraños residuos de sabiduría mágica y haciendo un tremendo alboroto acerca de su inteligencia." });

            migrationBuilder.InsertData(
                table: "Frase",
                columns: new[] { "Id", "Autor", "CategoriaId", "Fecha", "Texto" },
                values: new object[] { 246, "Earl Wilson.", 2, new DateTime(2019, 9, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "La ciencia nunca puede puede presentar un mejor sistema de comunicación en la oficina que en un descanso para el café." });

            migrationBuilder.InsertData(
                table: "Frase",
                columns: new[] { "Id", "Autor", "CategoriaId", "Fecha", "Texto" },
                values: new object[] { 245, "Robert A. Heinlein.", 2, new DateTime(2019, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Todo es teóricamente imposible, hasta que es hecho." });

            migrationBuilder.InsertData(
                table: "Frase",
                columns: new[] { "Id", "Autor", "CategoriaId", "Fecha", "Texto" },
                values: new object[] { 244, "H. L. Mencken.", 2, new DateTime(2019, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "La democracia es el arte y la ciencia de correr en círculos en una jaula de monos." });

            migrationBuilder.InsertData(
                table: "Frase",
                columns: new[] { "Id", "Autor", "CategoriaId", "Fecha", "Texto" },
                values: new object[] { 243, "William Osler.", 2, new DateTime(2019, 8, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "La medicina es una ciencia incierta y un arte de la probabilidad." });

            migrationBuilder.InsertData(
                table: "Frase",
                columns: new[] { "Id", "Autor", "CategoriaId", "Fecha", "Texto" },
                values: new object[] { 242, "Richard Feynman.", 2, new DateTime(2019, 8, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Tramamos de demostrar que estamos equivocados lo más rápido posible, porque solo así podemos progresar." });

            migrationBuilder.InsertData(
                table: "Frase",
                columns: new[] { "Id", "Autor", "CategoriaId", "Fecha", "Texto" },
                values: new object[] { 241, "Bernard M. Baruch.", 2, new DateTime(2019, 8, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Millones vieron a una manzana caer, Newton fue el único que se preguntó ¿Por qué?." });

            migrationBuilder.InsertData(
                table: "Frase",
                columns: new[] { "Id", "Autor", "CategoriaId", "Fecha", "Texto" },
                values: new object[] { 240, "Sigmund Freud.", 2, new DateTime(2019, 8, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "No, nuestra ciencia no es una ilusión. Pero una ilusión seria suponer que lo que la ciencia no puede darnos podemos conseguirlo en otro lugar." });

            migrationBuilder.InsertData(
                table: "Frase",
                columns: new[] { "Id", "Autor", "CategoriaId", "Fecha", "Texto" },
                values: new object[] { 239, "Bill Bryson.", 2, new DateTime(2019, 8, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hay tres etapas en el descubrimiento de la ciencia. Primero, las personas niegan que es cierto, luego niegan que es importante; finalmente le dan el crédito a la persona equivocada." });

            migrationBuilder.InsertData(
                table: "Frase",
                columns: new[] { "Id", "Autor", "CategoriaId", "Fecha", "Texto" },
                values: new object[] { 238, "H. G. Wells.", 2, new DateTime(2019, 8, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "La naturaleza nunca busca la inteligencia hasta que el hábito y el instinto son inservibles. No existe inteligencia donde no hay necesidad de cambio." });

            migrationBuilder.InsertData(
                table: "Frase",
                columns: new[] { "Id", "Autor", "CategoriaId", "Fecha", "Texto" },
                values: new object[] { 257, "Albert Einstein.", 2, new DateTime(2019, 9, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Es más difícil romper un prejuicio que un átomo." });

            migrationBuilder.InsertData(
                table: "Frase",
                columns: new[] { "Id", "Autor", "CategoriaId", "Fecha", "Texto" },
                values: new object[] { 258, "Ernst Mach.", 3, new DateTime(2019, 9, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "La física es experiencia, colocada en orden económico" });

            migrationBuilder.InsertData(
                table: "Frase",
                columns: new[] { "Id", "Autor", "CategoriaId", "Fecha", "Texto" },
                values: new object[] { 259, "Albert Einstein.", 3, new DateTime(2019, 9, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Para nosotros los físicos, creer en la separación entre el pasado, presente y futuro solo es una ilusión, aunque una muy convincente. " });

            migrationBuilder.InsertData(
                table: "Frase",
                columns: new[] { "Id", "Autor", "CategoriaId", "Fecha", "Texto" },
                values: new object[] { 260, "Isaac Newton.", 3, new DateTime(2019, 9, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Puedo calcular el movimiento de los cuerpos celestes, pero no la locura de la gente. " });

            migrationBuilder.InsertData(
                table: "Frase",
                columns: new[] { "Id", "Autor", "CategoriaId", "Fecha", "Texto" },
                values: new object[] { 280, "Stephen Hawking.", 3, new DateTime(2019, 10, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Si bien la física y las matemáticas nos dicen cómo comenzó el Universo, no sirven para predecir el comportamiento humano. " });

            migrationBuilder.InsertData(
                table: "Frase",
                columns: new[] { "Id", "Autor", "CategoriaId", "Fecha", "Texto" },
                values: new object[] { 279, "Max Planck.", 3, new DateTime(2019, 10, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "Un experimento es una pregunta que la ciencia le plantea a la naturaleza, y una medición es el registro de la respuesta de la naturaleza. " });

            migrationBuilder.InsertData(
                table: "Frase",
                columns: new[] { "Id", "Autor", "CategoriaId", "Fecha", "Texto" },
                values: new object[] { 278, "Niels Bohr.", 3, new DateTime(2019, 10, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Es incorrecto pensar que el objetivo de la física es descubrir cómo es la naturaleza. La física lidia con lo que decimos acerca de la naturaleza. " });

            migrationBuilder.InsertData(
                table: "Frase",
                columns: new[] { "Id", "Autor", "CategoriaId", "Fecha", "Texto" },
                values: new object[] { 277, "Ernest Rutherford.", 3, new DateTime(2019, 10, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Toda la física es o bien imposible o trivial. Es imposible hasta que la entiendes, y luego se vuelve trivial. " });

            migrationBuilder.InsertData(
                table: "Frase",
                columns: new[] { "Id", "Autor", "CategoriaId", "Fecha", "Texto" },
                values: new object[] { 276, "Albert Einstein.", 3, new DateTime(2019, 10, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "La física se trata de entender cómo descubrir cosas nuevas que son contraintuitivas, como la mecánica cuántica. Es realmente contradictoria. " });

            migrationBuilder.InsertData(
                table: "Frase",
                columns: new[] { "Id", "Autor", "CategoriaId", "Fecha", "Texto" },
                values: new object[] { 275, "Galileo Galilei.", 3, new DateTime(2019, 10, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Las matemáticas son el lenguaje en el que Dios ha escrito el Universo. " });

            migrationBuilder.InsertData(
                table: "Frase",
                columns: new[] { "Id", "Autor", "CategoriaId", "Fecha", "Texto" },
                values: new object[] { 274, "Nikola Tesla.", 3, new DateTime(2019, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Lo que un hombre llama Dios, otro lo llama leyes de la física. " });

            migrationBuilder.InsertData(
                table: "Frase",
                columns: new[] { "Id", "Autor", "CategoriaId", "Fecha", "Texto" },
                values: new object[] { 273, "Niels Bohr.", 3, new DateTime(2019, 9, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Aquellos que no se impresionaron la primera vez que se toparon con la teoría cuántica, es posible que ni siquiera la hayan entendido. " });

            migrationBuilder.InsertData(
                table: "Frase",
                columns: new[] { "Id", "Autor", "CategoriaId", "Fecha", "Texto" },
                values: new object[] { 272, "Krishan Kumar.", 3, new DateTime(2019, 9, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "El amor no es lo más importante. La física lo es. " });

            migrationBuilder.InsertData(
                table: "Frase",
                columns: new[] { "Id", "Autor", "CategoriaId", "Fecha", "Texto" },
                values: new object[] { 237, "Carl Sagan.", 2, new DateTime(2019, 8, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Lo hermoso de las cosas vivas no son los átomos que llevan dentro, sino cómo esos átomos se juntan." });

            migrationBuilder.InsertData(
                table: "Frase",
                columns: new[] { "Id", "Autor", "CategoriaId", "Fecha", "Texto" },
                values: new object[] { 271, "Edward Teller.", 3, new DateTime(2019, 9, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "La física es, con suerte, simple. Los físicos no lo son. " });

            migrationBuilder.InsertData(
                table: "Frase",
                columns: new[] { "Id", "Autor", "CategoriaId", "Fecha", "Texto" },
                values: new object[] { 269, "David Hilbert.", 3, new DateTime(2019, 9, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "La física se está volviendo demasiado difícil para los físicos. " });

            migrationBuilder.InsertData(
                table: "Frase",
                columns: new[] { "Id", "Autor", "CategoriaId", "Fecha", "Texto" },
                values: new object[] { 268, "Leon M. Lederman.", 3, new DateTime(2019, 9, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "La física no es una religión. Si así lo fuera, sería mucho más fácil para nosotros conseguir dinero. " });

            migrationBuilder.InsertData(
                table: "Frase",
                columns: new[] { "Id", "Autor", "CategoriaId", "Fecha", "Texto" },
                values: new object[] { 267, "J. Robert Oppenheimer.", 3, new DateTime(2019, 9, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "Necesito más a la física que a los amigos. " });

            migrationBuilder.InsertData(
                table: "Frase",
                columns: new[] { "Id", "Autor", "CategoriaId", "Fecha", "Texto" },
                values: new object[] { 266, "Richard P. Feynman.", 3, new DateTime(2019, 9, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Solo los físicos pueden pensar en la misma cosa una y otra vez. " });

            migrationBuilder.InsertData(
                table: "Frase",
                columns: new[] { "Id", "Autor", "CategoriaId", "Fecha", "Texto" },
                values: new object[] { 265, "Richard P. Feynman.", 3, new DateTime(2019, 9, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Una de las más grandes y más importantes herramientas del físico teórico es el cubo de basura. " });

            migrationBuilder.InsertData(
                table: "Frase",
                columns: new[] { "Id", "Autor", "CategoriaId", "Fecha", "Texto" },
                values: new object[] { 264, "Katherine Johnson.", 3, new DateTime(2019, 9, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "Todo es física y matemáticas. " });

            migrationBuilder.InsertData(
                table: "Frase",
                columns: new[] { "Id", "Autor", "CategoriaId", "Fecha", "Texto" },
                values: new object[] { 263, "Freeman Dyson.", 3, new DateTime(2019, 9, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "La física está llena de los cadáveres de teorías unificadas de campos. " });

            migrationBuilder.InsertData(
                table: "Frase",
                columns: new[] { "Id", "Autor", "CategoriaId", "Fecha", "Texto" },
                values: new object[] { 262, "Ernest Rutherford.", 3, new DateTime(2019, 9, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Toda la ciencia es o física o coleccionar estampillas. " });

            migrationBuilder.InsertData(
                table: "Frase",
                columns: new[] { "Id", "Autor", "CategoriaId", "Fecha", "Texto" },
                values: new object[] { 261, "Neil deGrasse Tyson.", 3, new DateTime(2019, 9, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "La física es la única profesión en la cual la predicción no solo es precisa, sino una rutina. " });

            migrationBuilder.InsertData(
                table: "Frase",
                columns: new[] { "Id", "Autor", "CategoriaId", "Fecha", "Texto" },
                values: new object[] { 270, "Niels Bohr.", 3, new DateTime(2019, 9, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Un físico es solo la manera en que un átomo se mira a sí mismo. " });

            migrationBuilder.InsertData(
                table: "Frase",
                columns: new[] { "Id", "Autor", "CategoriaId", "Fecha", "Texto" },
                values: new object[] { 281, "Stephen Hawking.", 3, new DateTime(2019, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "La física teórica es uno de los pocos campos en los que estar discapacitado no es una discapacidad. Todo está en la mente. " });

            migrationBuilder.InsertData(
                table: "Frase",
                columns: new[] { "Id", "Autor", "CategoriaId", "Fecha", "Texto" },
                values: new object[] { 236, "Michael Crichton.", 2, new DateTime(2019, 8, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dios creó a los dinosaurios, Dioa mató a los dinosaurios, Dios creó al hombre, el hombre mató a Dios, el hombre trajo de vuelta a los dinosaurios." });

            migrationBuilder.InsertData(
                table: "Frase",
                columns: new[] { "Id", "Autor", "CategoriaId", "Fecha", "Texto" },
                values: new object[] { 234, "Thomas A. Edison.", 2, new DateTime(2019, 8, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Para inventar, necesitas una buena imaginación y una pila de basura." });

            migrationBuilder.InsertData(
                table: "Frase",
                columns: new[] { "Id", "Autor", "CategoriaId", "Fecha", "Texto" },
                values: new object[] { 209, "Charles Lindbergh.", 2, new DateTime(2019, 7, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "He visto la ciencia en la que he trabajado y la maquinaria aérea que he amado, destruir la civilización que esperé que sirviera." });

            migrationBuilder.InsertData(
                table: "Frase",
                columns: new[] { "Id", "Autor", "CategoriaId", "Fecha", "Texto" },
                values: new object[] { 208, "Henry Petroski.", 2, new DateTime(2019, 7, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "La ciencia se trata de saber, la ingeniería de hacer." });

            migrationBuilder.InsertData(
                table: "Frase",
                columns: new[] { "Id", "Autor", "CategoriaId", "Fecha", "Texto" },
                values: new object[] { 207, "George Bernard Shaw.", 2, new DateTime(2019, 7, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "El cerebro de un necio digiere la filosofía en locura, la ciencia en superstición y el arte en pedantería. De ahí la educación universitaria." });

            migrationBuilder.InsertData(
                table: "Frase",
                columns: new[] { "Id", "Autor", "CategoriaId", "Fecha", "Texto" },
                values: new object[] { 206, "Aldous Huxley.", 2, new DateTime(2019, 7, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Cuanto más poderosa y original sea una mente, más se inclinará hacia la religión de la soledad." });

            migrationBuilder.InsertData(
                table: "Frase",
                columns: new[] { "Id", "Autor", "CategoriaId", "Fecha", "Texto" },
                values: new object[] { 205, "William Blake.", 2, new DateTime(2019, 7, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "El arte es el árbol de la vida, la ciencia es el árbol de la muerte." });

            migrationBuilder.InsertData(
                table: "Frase",
                columns: new[] { "Id", "Autor", "CategoriaId", "Fecha", "Texto" },
                values: new object[] { 204, "Helen Keller.", 2, new DateTime(2019, 7, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "La ciencia habrá encontrado la cura para la mayoría de los males, pero aún no haya el remedio para para el peor de ellos: la apatía humana." });

            migrationBuilder.InsertData(
                table: "Frase",
                columns: new[] { "Id", "Autor", "CategoriaId", "Fecha", "Texto" },
                values: new object[] { 203, "Alan Perlis.", 2, new DateTime(2019, 7, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Una año investigando la inteligencia artificial es suficiente para comenzar a creer en Dios." });

            migrationBuilder.InsertData(
                table: "Frase",
                columns: new[] { "Id", "Autor", "CategoriaId", "Fecha", "Texto" },
                values: new object[] { 202, "Charles Darwin.", 2, new DateTime(2019, 7, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "En la versión ordinaria donde cada especie se ha creado independientemente, no obtenemos ninguna explicación científica." });

            migrationBuilder.InsertData(
                table: "Frase",
                columns: new[] { "Id", "Autor", "CategoriaId", "Fecha", "Texto" },
                values: new object[] { 201, "Edgar Allan Poe.", 2, new DateTime(2019, 7, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "La ciencia aún no nos ha comprobado si la locura es o no la cúspide sublime de la inteligencia." });

            migrationBuilder.InsertData(
                table: "Frase",
                columns: new[] { "Id", "Autor", "CategoriaId", "Fecha", "Texto" },
                values: new object[] { 200, "Carl Sagan.", 2, new DateTime(2019, 7, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hemos establecido la civilización de manera que los más cruciales elementos dependen de la ciencia y la tecnología." });

            migrationBuilder.InsertData(
                table: "Frase",
                columns: new[] { "Id", "Autor", "CategoriaId", "Fecha", "Texto" },
                values: new object[] { 199, "Arthur M. Schlesinger.", 2, new DateTime(2019, 7, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "La ciencia y la tecnología revolucionan nuestras vidas, pero la memoria, tradición y el mito enmarcan nuestra respuesta." });

            migrationBuilder.InsertData(
                table: "Frase",
                columns: new[] { "Id", "Autor", "CategoriaId", "Fecha", "Texto" },
                values: new object[] { 198, "Adam Smith.", 2, new DateTime(2019, 7, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "La ciencia es el gran antídoto al veneno del entusiasmo y la superstición." });

            migrationBuilder.InsertData(
                table: "Frase",
                columns: new[] { "Id", "Autor", "CategoriaId", "Fecha", "Texto" },
                values: new object[] { 197, "Thomas Berger.", 2, new DateTime(2019, 7, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "El arte y la ciencia de hacer preguntas es la fuente de todo conocimiento." });

            migrationBuilder.InsertData(
                table: "Frase",
                columns: new[] { "Id", "Autor", "CategoriaId", "Fecha", "Texto" },
                values: new object[] { 196, "Jacob Bronowski.", 2, new DateTime(2019, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ninguna ciencia es inmune a la infección de la política y a la corrupción del poder." });

            migrationBuilder.InsertData(
                table: "Frase",
                columns: new[] { "Id", "Autor", "CategoriaId", "Fecha", "Texto" },
                values: new object[] { 195, "Louis D. Brandeis.", 2, new DateTime(2019, 7, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "No existen atajos para la evolución." });

            migrationBuilder.InsertData(
                table: "Frase",
                columns: new[] { "Id", "Autor", "CategoriaId", "Fecha", "Texto" },
                values: new object[] { 194, "Oscar Wilde.", 2, new DateTime(2019, 7, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "El éxito es una ciencia, si tienes las condiciones, obendrás el resultado." });

            migrationBuilder.InsertData(
                table: "Frase",
                columns: new[] { "Id", "Autor", "CategoriaId", "Fecha", "Texto" },
                values: new object[] { 193, "Abraham Lincoln.", 2, new DateTime(2019, 7, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Puedo ver cómo es posible que un hombre mire hacia abajo sobre la Tierra y sea ateo, pero no puedo concebir cómo un hombre puede mirara los cielos y decir que no hay un Dios." });

            migrationBuilder.InsertData(
                table: "Frase",
                columns: new[] { "Id", "Autor", "CategoriaId", "Fecha", "Texto" },
                values: new object[] { 192, "George Santayana.", 2, new DateTime(2019, 7, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "La ciencia no es más que percepción desarrollada, intención interpretada, sentido común redondeado y minuciosamente articulado." });

            migrationBuilder.InsertData(
                table: "Frase",
                columns: new[] { "Id", "Autor", "CategoriaId", "Fecha", "Texto" },
                values: new object[] { 191, "Henri Poincaré.", 2, new DateTime(2019, 7, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "La ciencia son hechos, así como las casas están hechas de piedras, la ciencia esta hecha de hechos." });

            migrationBuilder.InsertData(
                table: "Frase",
                columns: new[] { "Id", "Autor", "CategoriaId", "Fecha", "Texto" },
                values: new object[] { 210, "Mark Russell.", 2, new DateTime(2019, 7, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "La teoría científica que más me gusta es que los anillos de Saturno se componen enteramente de equipaje de avión perdido." });

            migrationBuilder.InsertData(
                table: "Frase",
                columns: new[] { "Id", "Autor", "CategoriaId", "Fecha", "Texto" },
                values: new object[] { 211, "Juan Pablo II.", 2, new DateTime(2019, 7, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "La ciencia puede purificar a la religión del error y la superstición. La religión puede purificar a la ciencia de la idolatría y falsos absolutos." });

            migrationBuilder.InsertData(
                table: "Frase",
                columns: new[] { "Id", "Autor", "CategoriaId", "Fecha", "Texto" },
                values: new object[] { 212, "Ada Lovelace.", 2, new DateTime(2019, 7, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "La ciencia de las operaciones, derivada de las matemáticas mayormente, es una ciencia en sí misma; tiene su propio valor y verdad abstractos." });

            migrationBuilder.InsertData(
                table: "Frase",
                columns: new[] { "Id", "Autor", "CategoriaId", "Fecha", "Texto" },
                values: new object[] { 213, "Karl Popper.", 2, new DateTime(2019, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "La ciencia puede ser descrita como el arte de la súper simplificación sistematizada." });

            migrationBuilder.InsertData(
                table: "Frase",
                columns: new[] { "Id", "Autor", "CategoriaId", "Fecha", "Texto" },
                values: new object[] { 233, "Victor J. Stenger.", 2, new DateTime(2019, 8, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "La ciencia te lleva a la luna. La religión te lleva dentro de los edificios." });

            migrationBuilder.InsertData(
                table: "Frase",
                columns: new[] { "Id", "Autor", "CategoriaId", "Fecha", "Texto" },
                values: new object[] { 232, "Richard Feynman.", 2, new DateTime(2019, 8, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "La religión es una cultura de la fe; la ciencia es la cultura de la duda." });

            migrationBuilder.InsertData(
                table: "Frase",
                columns: new[] { "Id", "Autor", "CategoriaId", "Fecha", "Texto" },
                values: new object[] { 231, "Carl Sagan.", 2, new DateTime(2019, 8, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "No quiero creer. Quiero saber." });

            migrationBuilder.InsertData(
                table: "Frase",
                columns: new[] { "Id", "Autor", "CategoriaId", "Fecha", "Texto" },
                values: new object[] { 230, "Richard Feynman.", 2, new DateTime(2019, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "El primer principio es que no debes engañarte a ti mismo cuando eres el más fácil de engañar." });

            migrationBuilder.InsertData(
                table: "Frase",
                columns: new[] { "Id", "Autor", "CategoriaId", "Fecha", "Texto" },
                values: new object[] { 229, "Nikola Tesla.", 2, new DateTime(2019, 8, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "El día en que la ciencia empiece a estudiar fenómenos no físicos, habrá mas progreso en una década que en todos los siglos previos de existencia." });

            migrationBuilder.InsertData(
                table: "Frase",
                columns: new[] { "Id", "Autor", "CategoriaId", "Fecha", "Texto" },
                values: new object[] { 228, "Will Durant.", 2, new DateTime(2019, 8, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "La ciencia es el conocimiento organizado. La sabiduría es vida organizada." });

            migrationBuilder.InsertData(
                table: "Frase",
                columns: new[] { "Id", "Autor", "CategoriaId", "Fecha", "Texto" },
                values: new object[] { 227, "Richard Feynman.", 2, new DateTime(2019, 8, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Aprendí muy temprano la diferencia entre saber el nombre de algo y saber algo." });

            migrationBuilder.InsertData(
                table: "Frase",
                columns: new[] { "Id", "Autor", "CategoriaId", "Fecha", "Texto" },
                values: new object[] { 226, "Claude Lévi-Strauss", 2, new DateTime(2019, 8, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "El científico no es una persona que ofrece las respuestas correctas, es quien hace las preguntas correctas." });

            migrationBuilder.InsertData(
                table: "Frase",
                columns: new[] { "Id", "Autor", "CategoriaId", "Fecha", "Texto" },
                values: new object[] { 225, "Albert Einstein.", 2, new DateTime(2019, 8, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Leer, después de cierta edad, distrae mucho a la mente de sus actividades creativas. Cualquier hombre que lea demasiado y use su cerebro muy poco se vuelve flojo de pensamiento." });

            migrationBuilder.InsertData(
                table: "Frase",
                columns: new[] { "Id", "Autor", "CategoriaId", "Fecha", "Texto" },
                values: new object[] { 235, "Arthur C. Clarke.", 2, new DateTime(2019, 8, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Que inapropiado es llamar al planeta “Tierra”, cuando es claramente “Océano”." });

            migrationBuilder.InsertData(
                table: "Frase",
                columns: new[] { "Id", "Autor", "CategoriaId", "Fecha", "Texto" },
                values: new object[] { 224, "Albert Einstein.", 2, new DateTime(2019, 8, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "La sabiduría no es el producto de la educación pero si del intento de toda la vida para adquirirla." });

            migrationBuilder.InsertData(
                table: "Frase",
                columns: new[] { "Id", "Autor", "CategoriaId", "Fecha", "Texto" },
                values: new object[] { 222, "Michael Crichton.", 2, new DateTime(2019, 8, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "¿Sabes cómo llamamos a las opiniones que carecen de evidencia? Las llamamos prejuicios." });

            migrationBuilder.InsertData(
                table: "Frase",
                columns: new[] { "Id", "Autor", "CategoriaId", "Fecha", "Texto" },
                values: new object[] { 221, "R. Buckminster Fuller.", 2, new DateTime(2019, 8, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Nunca cambias las cosas peleando por la realidad existente. Para cambiar algo, inventa un nuevo modelo que haga que el modelo existente sea obsoleto." });

            migrationBuilder.InsertData(
                table: "Frase",
                columns: new[] { "Id", "Autor", "CategoriaId", "Fecha", "Texto" },
                values: new object[] { 220, "Richard Feynman.", 2, new DateTime(2019, 8, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "La física es como el sexo: seguramente, dará algunos resultados prácticos, pero esa no es la razón por lo que lo hacemos." });

            migrationBuilder.InsertData(
                table: "Frase",
                columns: new[] { "Id", "Autor", "CategoriaId", "Fecha", "Texto" },
                values: new object[] { 219, "Isaac Asimov.", 2, new DateTime(2019, 8, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Lo que asumes son tus ventanas en el mundo. Límpialas de vez en cuando, sino la luz no entrará." });

            migrationBuilder.InsertData(
                table: "Frase",
                columns: new[] { "Id", "Autor", "CategoriaId", "Fecha", "Texto" },
                values: new object[] { 218, "Isaac Newton.", 2, new DateTime(2019, 8, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "Si he visto más allá es porque me he levantado sobre los hombros de los gigantes." });

            migrationBuilder.InsertData(
                table: "Frase",
                columns: new[] { "Id", "Autor", "CategoriaId", "Fecha", "Texto" },
                values: new object[] { 217, "Marie Curie.", 2, new DateTime(2019, 8, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "No hay nada que temer en la vida, únicamente se debe entender. Ahora es tiempo de entender más, para temer menos." });

            migrationBuilder.InsertData(
                table: "Frase",
                columns: new[] { "Id", "Autor", "CategoriaId", "Fecha", "Texto" },
                values: new object[] { 216, "Albert Einstein.", 2, new DateTime(2019, 8, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "La experiencia más bella que podemos tener es misteriosa. Es la emoción fundamental que se encuentra en la cuna del verdadero arte y la verdadera ciencia." });

            migrationBuilder.InsertData(
                table: "Frase",
                columns: new[] { "Id", "Autor", "CategoriaId", "Fecha", "Texto" },
                values: new object[] { 215, "Oscar Wilde.", 2, new DateTime(2019, 8, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "El romance nunca debe comenzar con el sentimiento. Debe comenzar con la ciencia y terminar con un acuerdo." });

            migrationBuilder.InsertData(
                table: "Frase",
                columns: new[] { "Id", "Autor", "CategoriaId", "Fecha", "Texto" },
                values: new object[] { 214, "Werner Heisenberg.", 2, new DateTime(2019, 8, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Las ciencias naturales no solo describen y explican la naturaleza, son parte del juego interno entre la naturaleza y nosotros mismos." });

            migrationBuilder.InsertData(
                table: "Frase",
                columns: new[] { "Id", "Autor", "CategoriaId", "Fecha", "Texto" },
                values: new object[] { 223, "Ray Bradbury.", 2, new DateTime(2019, 8, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Somos una imposibilidad en un imposible universo." });

            migrationBuilder.InsertData(
                table: "Frase",
                columns: new[] { "Id", "Autor", "CategoriaId", "Fecha", "Texto" },
                values: new object[] { 190, "Immanuel Kant.", 2, new DateTime(2019, 7, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "La ciencia es un conocimiento organizado. La sabiduría es la vida organizada." });

            migrationBuilder.InsertData(
                table: "Frase",
                columns: new[] { "Id", "Autor", "CategoriaId", "Fecha", "Texto" },
                values: new object[] { 282, "Michael Faraday.", 3, new DateTime(2019, 10, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ahora mismo estoy ocupado nuevamente con el electromagnetismo, y creo que haber conseguido algo bueno. " });

            migrationBuilder.InsertData(
                table: "Frase",
                columns: new[] { "Id", "Autor", "CategoriaId", "Fecha", "Texto" },
                values: new object[] { 284, "Stephen Hawking.", 3, new DateTime(2019, 10, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Nadie realiza investigación en el área de la física con la intención de ganar un premio. Es por la alegría de descubrir algo que nadie más sabía. " });

            migrationBuilder.InsertData(
                table: "Frase",
                columns: new[] { "Id", "Autor", "CategoriaId", "Fecha", "Texto" },
                values: new object[] { 350, "Elon Musk.", 3, new DateTime(2019, 12, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Tiendo a afrontar las cosas con un abordamiento físico. Y la física te enseña a razonar primero con los principios en vez de por analogía. " });

            migrationBuilder.InsertData(
                table: "Frase",
                columns: new[] { "Id", "Autor", "CategoriaId", "Fecha", "Texto" },
                values: new object[] { 349, "Angela Merkel.", 3, new DateTime(2019, 12, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Escogí una carrera en física porque ahí la verdad no es tan fácilmente tergiversada. " });

            migrationBuilder.InsertData(
                table: "Frase",
                columns: new[] { "Id", "Autor", "CategoriaId", "Fecha", "Texto" },
                values: new object[] { 348, "Niels Bohr.", 3, new DateTime(2019, 12, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "La física es la creencia de que una descripción simple y consistente de la naturaleza es posible. " });

            migrationBuilder.InsertData(
                table: "Frase",
                columns: new[] { "Id", "Autor", "CategoriaId", "Fecha", "Texto" },
                values: new object[] { 347, "Stephen Hawking.", 3, new DateTime(2019, 12, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mi padre era un científico investigador, así que siempre pensé que yo también lo sería. Sentí que la medicina era muy vaga e inexacta, así que escogí la física. " });

            migrationBuilder.InsertData(
                table: "Frase",
                columns: new[] { "Id", "Autor", "CategoriaId", "Fecha", "Texto" },
                values: new object[] { 346, "Owen Chamberlain.", 3, new DateTime(2019, 12, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "El desarrollo de la física, así como el desarrollo de cualquier ciencia, es continuo. " });

            migrationBuilder.InsertData(
                table: "Frase",
                columns: new[] { "Id", "Autor", "CategoriaId", "Fecha", "Texto" },
                values: new object[] { 345, "Willard Gibbs.", 3, new DateTime(2019, 12, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Un matemático puede decir todo lo que quiera, pero un físico tiene que estar al menos parcialmente cuerdo. " });

            migrationBuilder.InsertData(
                table: "Frase",
                columns: new[] { "Id", "Autor", "CategoriaId", "Fecha", "Texto" },
                values: new object[] { 344, "Freeman Dyson.", 3, new DateTime(2019, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Para un físico, las matemáticas no son simplemente una herramienta mediante la cual los fenómenos pueden ser calculados, es la fuente principal de conceptos y principios mediante los cuales pueden ser creadas nuevas teorías. " });

            migrationBuilder.InsertData(
                table: "Frase",
                columns: new[] { "Id", "Autor", "CategoriaId", "Fecha", "Texto" },
                values: new object[] { 343, "David Griffiths.", 3, new DateTime(2019, 12, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Cuando escuches a un físico invocar el principio de la incertidumbre, agarra bien tu cartera. " });

            migrationBuilder.InsertData(
                table: "Frase",
                columns: new[] { "Id", "Autor", "CategoriaId", "Fecha", "Texto" },
                values: new object[] { 342, "Heinz R. Pagels.", 3, new DateTime(2019, 12, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Los físicos teóricos y experimentales ahora están estudiando la nada, el vacío. Pero esa nada lo contiene todo. " });

            migrationBuilder.InsertData(
                table: "Frase",
                columns: new[] { "Id", "Autor", "CategoriaId", "Fecha", "Texto" },
                values: new object[] { 341, "Victor Weisskopf.", 3, new DateTime(2019, 12, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "La autoconfianza es un ingrediente importante en la formación un físico exitoso. " });

            migrationBuilder.InsertData(
                table: "Frase",
                columns: new[] { "Id", "Autor", "CategoriaId", "Fecha", "Texto" },
                values: new object[] { 340, "Erwin Schrödinger.", 3, new DateTime(2019, 12, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "Lo que observamos como cuerpos materiales y fuerzas son nada más que formas y variaciones en la estructura del espacio. " });

            migrationBuilder.InsertData(
                table: "Frase",
                columns: new[] { "Id", "Autor", "CategoriaId", "Fecha", "Texto" },
                values: new object[] { 339, "Michio Kaku.", 3, new DateTime(2019, 12, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Lo que generalmente consideramos como imposibles son simplemente problemas de ingeniería… no existen leyes de la física que lo prevengan. " });

            migrationBuilder.InsertData(
                table: "Frase",
                columns: new[] { "Id", "Autor", "CategoriaId", "Fecha", "Texto" },
                values: new object[] { 338, "Daniel Bernoulli.", 3, new DateTime(2019, 12, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sería mucho mejor para la verdadera física si no existieran matemáticos en la tierra. " });

            migrationBuilder.InsertData(
                table: "Frase",
                columns: new[] { "Id", "Autor", "CategoriaId", "Fecha", "Texto" },
                values: new object[] { 337, "Nikola Tesla.", 3, new DateTime(2019, 12, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Los científicos de hoy han sustituido las matemáticas por experimentos, y divagan entre ecuación y ecuación, eventualmente construyendo una estructura que no tiene relación con la realidad. " });

            migrationBuilder.InsertData(
                table: "Frase",
                columns: new[] { "Id", "Autor", "CategoriaId", "Fecha", "Texto" },
                values: new object[] { 336, "Fred Hoyle.", 3, new DateTime(2019, 12, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Existen muchas maneras de sacarle los electrones a los átomos. La manera más simple es frotando dos superficies juntas. " });

            migrationBuilder.InsertData(
                table: "Frase",
                columns: new[] { "Id", "Autor", "CategoriaId", "Fecha", "Texto" },
                values: new object[] { 335, "Brian Greene.", 3, new DateTime(2019, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "La evaluación de la existencia mientras se falla al aceptar las ideas de la física moderna sería como luchar en la oscuridad con un oponente desconocido. " });

            migrationBuilder.InsertData(
                table: "Frase",
                columns: new[] { "Id", "Autor", "CategoriaId", "Fecha", "Texto" },
                values: new object[] { 334, "Richard P. Feynman", 3, new DateTime(2019, 11, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "No hay nada que hagan los seres vivos que no pueda entenderse desde el punto de vista de que están hechos de átomos que actúan de acuerdo con las leyes de la física. " });

            migrationBuilder.InsertData(
                table: "Frase",
                columns: new[] { "Id", "Autor", "CategoriaId", "Fecha", "Texto" },
                values: new object[] { 333, "Lisa Randall.", 3, new DateTime(2019, 11, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "El modelo estándar de la física de partículas describe las fuerzas y las partículas muy bien, pero cuando entra la gravedad en la ecuación, tienes que meterte entre las ramas para hacerla funcionar. " });

            migrationBuilder.InsertData(
                table: "Frase",
                columns: new[] { "Id", "Autor", "CategoriaId", "Fecha", "Texto" },
                values: new object[] { 332, "Carl Sagan.", 3, new DateTime(2019, 11, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Para hacer una tarta de manzana desde cero, primero debes de crear el Universo. " });

            migrationBuilder.InsertData(
                table: "Frase",
                columns: new[] { "Id", "Autor", "CategoriaId", "Fecha", "Texto" },
                values: new object[] { 351, "Richard P. Feynman.", 3, new DateTime(2019, 12, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Siempre me parece extraño que cuando se descubren las leyes de la física, pueden aparecer en tantas formas diferentes que a la vista parecen no ser parecidas, pero, con un poco de manipulación matemática, se puede mostrar la relación. " });

            migrationBuilder.InsertData(
                table: "Frase",
                columns: new[] { "Id", "Autor", "CategoriaId", "Fecha", "Texto" },
                values: new object[] { 352, "Steven Weinberg.", 3, new DateTime(2019, 12, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Nada en la física parece tan esperanzador como la idea de que es posible que una teoría tenga un alto grado de simetría oculto ante nuestros en la vida cotidiana. La tarea del físico es encontrar esta simetría más profunda. " });

            migrationBuilder.InsertData(
                table: "Frase",
                columns: new[] { "Id", "Autor", "CategoriaId", "Fecha", "Texto" },
                values: new object[] { 353, "Michio Kaku.", 3, new DateTime(2019, 12, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Nadie sabe quién escribió las leyes de la física o de dónde vienen. La ciencia se basa en evidencia comprobable y reproducible, y hasta ahora no podemos probar el Universo antes del Big Bang. " });

            migrationBuilder.InsertData(
                table: "Frase",
                columns: new[] { "Id", "Autor", "CategoriaId", "Fecha", "Texto" },
                values: new object[] { 354, "Michio Kaku.", 3, new DateTime(2019, 12, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "¿Qué es el Universo? El Universo es la sinfonía de cuerdas vibrantes. No somos más que melodías. No somos más que música cósmica tocada en cuerdas y membranas vibrantes. " });

            migrationBuilder.InsertData(
                table: "Frase",
                columns: new[] { "Id", "Autor", "CategoriaId", "Fecha", "Texto" },
                values: new object[] { 374, "Marie Curie.", 3, new DateTime(2020, 1, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sería imposible, iría en contra del espíritu científico. Los físicos siempre deben publicar sus investigaciones completas. Si nuestro descubrimiento tiene un futuro comercial, es una circunstancia de la que no debemos sacar provecho. " });

            migrationBuilder.InsertData(
                table: "Frase",
                columns: new[] { "Id", "Autor", "CategoriaId", "Fecha", "Texto" },
                values: new object[] { 373, "Erwin Schrödinger.", 3, new DateTime(2020, 1, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Por otro lado, la interpretación verbal, es decir, la metafísica de la física cuántica, está parada en un terreno mucho menos sólido. De hecho, en más de cuarenta años los físicos no han podido proporcionar un modelo metafísico claro. " });

            migrationBuilder.InsertData(
                table: "Frase",
                columns: new[] { "Id", "Autor", "CategoriaId", "Fecha", "Texto" },
                values: new object[] { 372, "Michio Kaku.", 3, new DateTime(2020, 1, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Todas las partículas son vibraciones de una bandita elástica; la física son sus armonías; la química son las melodías que tocamos en ellas; el Universo es una sinfonía; y la “Mente de Dios” es música cósmica que resuena en un hiperespacio undecadimensional. " });

            migrationBuilder.InsertData(
                table: "Frase",
                columns: new[] { "Id", "Autor", "CategoriaId", "Fecha", "Texto" },
                values: new object[] { 371, "Eugene Wigner.", 3, new DateTime(2020, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "La física se está volviendo tan increíblemente compleja que cada vez toma más y más tiempo educar un físico. Toma tanto, de hecho, que para cuando entiende la naturaleza de los problemas físicos, ya es demasiado viejo para resolverlos. " });

            migrationBuilder.InsertData(
                table: "Frase",
                columns: new[] { "Id", "Autor", "CategoriaId", "Fecha", "Texto" },
                values: new object[] { 370, "Maria Goeppert", 3, new DateTime(2020, 1, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Las matemáticas se comenzaban a parecer mucho a la resolución de rompecabezas. La física también es la resolución de rompecabezas, pero de aquellos creados por la naturaleza, no por la mente del hombre. " });

            migrationBuilder.InsertData(
                table: "Frase",
                columns: new[] { "Id", "Autor", "CategoriaId", "Fecha", "Texto" },
                values: new object[] { 369, "Richard P. Feynman.", 3, new DateTime(2020, 1, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "La teoría gravitacional de Einstein, el cual se dice que fue el mayor logro individual de la física teórica, resultó en hermosas relaciones que conectan los fenómenos gravitaciones con la geometría del espacio. Esta era una idea emocionante. " });

            migrationBuilder.InsertData(
                table: "Frase",
                columns: new[] { "Id", "Autor", "CategoriaId", "Fecha", "Texto" },
                values: new object[] { 368, "Michio Kaku.", 3, new DateTime(2020, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ahora nos damos cuenta que todas estas partículas subatómicas, de las cuales cientos provienen de nuestros aceleradores, pueden ser explicadas por pequeñas cuerdas vibrantes. " });

            migrationBuilder.InsertData(
                table: "Frase",
                columns: new[] { "Id", "Autor", "CategoriaId", "Fecha", "Texto" },
                values: new object[] { 367, "Isaac Newton.", 3, new DateTime(2020, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "La fuerza inherente de la materia es la capacidad de resistirse, mediante la cual todo cuerpo, en la medida que le es posible, trata de permanecer en reposo o de moverse uniformemente en línea recta. " });

            migrationBuilder.InsertData(
                table: "Frase",
                columns: new[] { "Id", "Autor", "CategoriaId", "Fecha", "Texto" },
                values: new object[] { 366, "Paul C. W. Davies.", 3, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hasta ahora las teorías físicas habían sido consideradas simplemente como modelos que describen aproximadamente la realidad. Conforme estos mejoran, también su exactitud. " });

            migrationBuilder.InsertData(
                table: "Frase",
                columns: new[] { "Id", "Autor", "CategoriaId", "Fecha", "Texto" },
                values: new object[] { 331, "Neil Turok.", 3, new DateTime(2019, 11, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "La física cuántica es una de las cosas más difíciles de entender intuitivamente, porque básicamente establece que nuestra perspectiva clásica es errónea. " });

            migrationBuilder.InsertData(
                table: "Frase",
                columns: new[] { "Id", "Autor", "CategoriaId", "Fecha", "Texto" },
                values: new object[] { 365, "Francis Collins.", 3, new DateTime(2019, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Me hice ateo porque como un estudiante de posgrado de física cuántica, la vida parecía ser reducible a ecuaciones diferenciales de segundo orden. Las matemáticas, la química y la física lo tenían todo. Y no veía la necesidad de ir más allá de eso. " });

            migrationBuilder.InsertData(
                table: "Frase",
                columns: new[] { "Id", "Autor", "CategoriaId", "Fecha", "Texto" },
                values: new object[] { 363, "Sir Arthur Eddington.", 3, new DateTime(2019, 12, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "En la teoría de la relatividad de Einstein, el observador es un hombre que emprende una búsqueda de la verdad armado con una vara de medir. En la teoría cuántica, este emprende un viaje con un colador. " });

            migrationBuilder.InsertData(
                table: "Frase",
                columns: new[] { "Id", "Autor", "CategoriaId", "Fecha", "Texto" },
                values: new object[] { 362, "Richard Davisson.", 3, new DateTime(2019, 12, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "No existen físicos en la partes más calientes del infierno, porque esto implicaría una diferencia de temperatura, y cualquier físico marginalmente competente usaría esto para hacer correr un motor térmico. " });

            migrationBuilder.InsertData(
                table: "Frase",
                columns: new[] { "Id", "Autor", "CategoriaId", "Fecha", "Texto" },
                values: new object[] { 361, "Wolfgang Pauli.", 3, new DateTime(2019, 12, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "La física es muy confusa de nuevo en este momento. De todos modos, es demasiado difícil para mí, ¡y me gustaría ser un comediante de cine o algo así y nunca haber oído nada sobre la física! " });

            migrationBuilder.InsertData(
                table: "Frase",
                columns: new[] { "Id", "Autor", "CategoriaId", "Fecha", "Texto" },
                values: new object[] { 360, "Richard P. Feynman.", 3, new DateTime(2019, 12, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "Un buen físico teórico hoy en día podría encontrar útil tener un amplio rango de perspectivas físicas y expresiones matemáticas de la misma teoría (por ejemplo de la electrodinámica cuántica) disponibles para él. " });

            migrationBuilder.InsertData(
                table: "Frase",
                columns: new[] { "Id", "Autor", "CategoriaId", "Fecha", "Texto" },
                values: new object[] { 359, "Carl Sagan.", 3, new DateTime(2019, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "El nitrógeno en nuestro ADN. El calcio en nuestros dientes. El hierro en nuestra sangre. El carbono en nuestras tartas de manzana fueron creados en el interior de estrellas colapsadas. Así que estamos hechos de polvo de estrellas. " });

            migrationBuilder.InsertData(
                table: "Frase",
                columns: new[] { "Id", "Autor", "CategoriaId", "Fecha", "Texto" },
                values: new object[] { 358, "Richard P. Feynman.", 3, new DateTime(2019, 12, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "Desde el punto de vista básico de la física, los fenómenos más interesantes son, por supuesto, los que ocurren en lugares nuevos, esos lugares donde las reglas no funcionan. Esa es la manera en la que descubrimos nuevas reglas. " });

            migrationBuilder.InsertData(
                table: "Frase",
                columns: new[] { "Id", "Autor", "CategoriaId", "Fecha", "Texto" },
                values: new object[] { 357, "Luis W. Álvarez.", 3, new DateTime(2019, 12, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Los físicos experimentales aman las herramientas de la física, porque para nosotros tienen una belleza intrínseca, y soñamos con encontrar nuevos secretos de la naturaleza tan importantes y emocionantes como los descubiertos por nuestros héroes. " });

            migrationBuilder.InsertData(
                table: "Frase",
                columns: new[] { "Id", "Autor", "CategoriaId", "Fecha", "Texto" },
                values: new object[] { 356, "Michio Kaku.", 3, new DateTime(2019, 12, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Se dice conmunmente que, de todas las teorías propuestas en este siglo, la más tonta es la teoría cuántica. De hecho, algunos dicen que lo único que tiene a su favor la teoría cuántica es que es indudablemente correcta. " });

            migrationBuilder.InsertData(
                table: "Frase",
                columns: new[] { "Id", "Autor", "CategoriaId", "Fecha", "Texto" },
                values: new object[] { 355, "Pierre Duhem.", 3, new DateTime(2019, 12, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "El físico nunca puede someter una hipótesis aislada a una prueba experimental, sino a todo un grupo de hipótesis. " });

            migrationBuilder.InsertData(
                table: "Frase",
                columns: new[] { "Id", "Autor", "CategoriaId", "Fecha", "Texto" },
                values: new object[] { 364, "Michio Kaku.", 3, new DateTime(2019, 12, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Si entiendes la física, la base de la teoría atómica y la relatividad, comprendes cómo se va a desarrollar el futuro. Entiendes las cosas que no son posibles. Entiendes por qué funcionan las cosas. " });

            migrationBuilder.InsertData(
                table: "Frase",
                columns: new[] { "Id", "Autor", "CategoriaId", "Fecha", "Texto" },
                values: new object[] { 283, "Marie Curie.", 3, new DateTime(2019, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Nada en la vida debe de ser temido, solo comprendido. Ahora es momento de entender más, para que podamos temer menos. " });

            migrationBuilder.InsertData(
                table: "Frase",
                columns: new[] { "Id", "Autor", "CategoriaId", "Fecha", "Texto" },
                values: new object[] { 330, "Stephen Hawking.", 3, new DateTime(2019, 11, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "La ciencia es hermosa cuando realiza explicaciones sencillas de los fenómenos o establece conexiones entre diferentes observaciones. Algunos ejemplos incluyen la doble hélice del ADN y las ecuaciones fundamentales de la física. " });

            migrationBuilder.InsertData(
                table: "Frase",
                columns: new[] { "Id", "Autor", "CategoriaId", "Fecha", "Texto" },
                values: new object[] { 328, "Brian Greene.", 3, new DateTime(2019, 11, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "Antes del descubrimiento de la mecánica cuántica, el enfoque de la física era el siguiente: si me dices cómo están las cosas ahora, puedo usar las leyes de la física para calcular y predecir cómo estarán después. " });

            migrationBuilder.InsertData(
                table: "Frase",
                columns: new[] { "Id", "Autor", "CategoriaId", "Fecha", "Texto" },
                values: new object[] { 303, "Paul Dirac.", 3, new DateTime(2019, 10, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Uno tal vez pueda describir la situación diciendo que Dios es un matemático de muy alto calibre y que usó matemáticas muy avanzadas para construir el universo. " });

            migrationBuilder.InsertData(
                table: "Frase",
                columns: new[] { "Id", "Autor", "CategoriaId", "Fecha", "Texto" },
                values: new object[] { 302, "Walter Lewin.", 3, new DateTime(2019, 10, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Los maestros que hacen de la física aburrida son criminales. " });

            migrationBuilder.InsertData(
                table: "Frase",
                columns: new[] { "Id", "Autor", "CategoriaId", "Fecha", "Texto" },
                values: new object[] { 301, "Stephen Hawking.", 3, new DateTime(2019, 10, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Los filósofos no han seguido el ritmo de los desarrollos modernos de la ciencia. Particularmente los de la física. " });

            migrationBuilder.InsertData(
                table: "Frase",
                columns: new[] { "Id", "Autor", "CategoriaId", "Fecha", "Texto" },
                values: new object[] { 300, "Albert Einstein.", 3, new DateTime(2019, 10, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Lo que la naturaleza requiere de nosotros no es una teoría cuántica o una teoría de ondas. En vez de eso, la naturaleza demanda una combinación de ambos conceptos, lo que hasta ahora excede las capacidades de pensamiento de los físicos. " });

            migrationBuilder.InsertData(
                table: "Frase",
                columns: new[] { "Id", "Autor", "CategoriaId", "Fecha", "Texto" },
                values: new object[] { 299, "John Wheeler.", 3, new DateTime(2019, 10, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "Aquellos que conocen a los físicos y los montañistas saben los rasgos que tienen en común: un espíritu de soñador, tenacidad de propósito y apertura para probar cualquier camino hacia la cima. " });

            migrationBuilder.InsertData(
                table: "Frase",
                columns: new[] { "Id", "Autor", "CategoriaId", "Fecha", "Texto" },
                values: new object[] { 298, "Lene Hau.", 3, new DateTime(2019, 10, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "La física se trata de cuestionar, estudiar e investigas la naturaleza. La investigas, y si tienes suerte, obtendrás pistas extrañas. " });

            migrationBuilder.InsertData(
                table: "Frase",
                columns: new[] { "Id", "Autor", "CategoriaId", "Fecha", "Texto" },
                values: new object[] { 297, "Albert Einstein.", 3, new DateTime(2019, 10, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dos cosas son infinitas: el Universo y la estupidez humana. Y del Universo no estoy seguro. " });

            migrationBuilder.InsertData(
                table: "Frase",
                columns: new[] { "Id", "Autor", "CategoriaId", "Fecha", "Texto" },
                values: new object[] { 296, "Adbus Salam.", 3, new DateTime(2019, 10, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "La creación de la física es el legado compartido de toda la humanidad. El este, el oeste, el norte y el sur, todos han contribuido en igual medida a él. " });

            migrationBuilder.InsertData(
                table: "Frase",
                columns: new[] { "Id", "Autor", "CategoriaId", "Fecha", "Texto" },
                values: new object[] { 295, "Isidor Isaac Rabi.", 3, new DateTime(2019, 10, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Creo que los físicos son los Peter Pan de la raza humana. Nunca crecen, y conservan su curiosidad. " });

            migrationBuilder.InsertData(
                table: "Frase",
                columns: new[] { "Id", "Autor", "CategoriaId", "Fecha", "Texto" },
                values: new object[] { 294, "Paul A. M. Dirac.", 3, new DateTime(2019, 10, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "Los físicos teóricos aceptan la necesidad de la belleza matemática como un acto de fe. Por ejemplo, la principal razón por la cuál la teoría de la relatividad es tan universalmente aceptada es por su belleza matemática. " });

            migrationBuilder.InsertData(
                table: "Frase",
                columns: new[] { "Id", "Autor", "CategoriaId", "Fecha", "Texto" },
                values: new object[] { 293, "Michio Kaku.", 3, new DateTime(2019, 10, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "La física es a menudo más extraña que la ciencia ficción, y creo que la ciencia ficción se basa en la física: dimensiones superiores, agujeros de gusano, la deformación del espacio y el tiempo, cosas así. " });

            migrationBuilder.InsertData(
                table: "Frase",
                columns: new[] { "Id", "Autor", "CategoriaId", "Fecha", "Texto" },
                values: new object[] { 292, "Erwin Schrödinger.", 3, new DateTime(2019, 10, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "La conciencia no puede explicarse en términos físicos. Ya que la conciencia es absolutamente fundamental. No puede explicarse en términos de otra cosa. " });

            migrationBuilder.InsertData(
                table: "Frase",
                columns: new[] { "Id", "Autor", "CategoriaId", "Fecha", "Texto" },
                values: new object[] { 291, "Werner Heisenberg.", 3, new DateTime(2019, 10, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "La influencia de Bohr en la física y en los físicos de nuestro tiempo fue más fuerte que la de cualquier otro, incluso que la de Einstein. " });

            migrationBuilder.InsertData(
                table: "Frase",
                columns: new[] { "Id", "Autor", "CategoriaId", "Fecha", "Texto" },
                values: new object[] { 290, "Michael Faraday.", 3, new DateTime(2019, 10, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Nada es demasiado maravilloso para ser verdad. " });

            migrationBuilder.InsertData(
                table: "Frase",
                columns: new[] { "Id", "Autor", "CategoriaId", "Fecha", "Texto" },
                values: new object[] { 289, "Andre Geim.", 3, new DateTime(2019, 10, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Lo importante acerca del grafeno, es la nueva física que se ha creado en torno a este. " });

            migrationBuilder.InsertData(
                table: "Frase",
                columns: new[] { "Id", "Autor", "CategoriaId", "Fecha", "Texto" },
                values: new object[] { 288, "Eugene Parker.", 3, new DateTime(2019, 10, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "El espacio, el Universo completo. No conozco un mejor lugar para descubrir nuevos aspectos de la física. " });

            migrationBuilder.InsertData(
                table: "Frase",
                columns: new[] { "Id", "Autor", "CategoriaId", "Fecha", "Texto" },
                values: new object[] { 287, "Lise Meitner.", 3, new DateTime(2019, 10, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Amo la física con todo mi corazón. Es como un tipo de amor personal, como el que alguien le tiene a una persona con quien está agradecida por muchas cosas. " });

            migrationBuilder.InsertData(
                table: "Frase",
                columns: new[] { "Id", "Autor", "CategoriaId", "Fecha", "Texto" },
                values: new object[] { 286, "Richard P. Feynman.", 3, new DateTime(2019, 10, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ves a los estudiantes de física que no la entienden. Nadie en realidad la entiende. " });

            migrationBuilder.InsertData(
                table: "Frase",
                columns: new[] { "Id", "Autor", "CategoriaId", "Fecha", "Texto" },
                values: new object[] { 285, "Brian Greene.", 3, new DateTime(2019, 10, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "La física trata de resolver las preguntas más grandes que el universo presenta. “¿De dónde surgió la totalidad del Universo?” “¿Tenemos un inicio?” " });

            migrationBuilder.InsertData(
                table: "Frase",
                columns: new[] { "Id", "Autor", "CategoriaId", "Fecha", "Texto" },
                values: new object[] { 304, "Paul Ehrenfest.", 3, new DateTime(2019, 10, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "¿No pueden estar dos electrones en el mismo estado? Por eso es que los átomos son tan innecesariamente grandes, y por eso los metales y las piedras son tan voluminosos. " });

            migrationBuilder.InsertData(
                table: "Frase",
                columns: new[] { "Id", "Autor", "CategoriaId", "Fecha", "Texto" },
                values: new object[] { 305, "Paul A. M. Dirac.", 3, new DateTime(2019, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mi investigación en la física ha consistido en simplemente examinar cantidades matemáticas de un tipo que los físicos usan y tratar de relacionarlas de una manera interesante. " });

            migrationBuilder.InsertData(
                table: "Frase",
                columns: new[] { "Id", "Autor", "CategoriaId", "Fecha", "Texto" },
                values: new object[] { 306, "Brian Greene.", 3, new DateTime(2019, 11, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "En resumidas cuentas, el viaje en el tiempo es permitido por las leyes de la física. " });

            migrationBuilder.InsertData(
                table: "Frase",
                columns: new[] { "Id", "Autor", "CategoriaId", "Fecha", "Texto" },
                values: new object[] { 307, "Michael Faraday.", 3, new DateTime(2019, 11, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "El término “físico” es tanto como para mi boca como para mis oídos tan extraño que creo que nunca lo utilizaré. " });

            migrationBuilder.InsertData(
                table: "Frase",
                columns: new[] { "Id", "Autor", "CategoriaId", "Fecha", "Texto" },
                values: new object[] { 327, "John Rader Platt.", 3, new DateTime(2019, 11, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ir a la Luna no es cuestión de física, sino de economía. " });

            migrationBuilder.InsertData(
                table: "Frase",
                columns: new[] { "Id", "Autor", "CategoriaId", "Fecha", "Texto" },
                values: new object[] { 326, "Bertrand Russell.", 3, new DateTime(2019, 11, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "El observador, cuando parece estar observando una piedra, está en realidad, si se cree en la física, observando los efectos de la piedra sobre él mismo. " });

            migrationBuilder.InsertData(
                table: "Frase",
                columns: new[] { "Id", "Autor", "CategoriaId", "Fecha", "Texto" },
                values: new object[] { 325, "Werner Heisenberg.", 3, new DateTime(2019, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "No solo el Universo es más extraño de lo que pensamos, es más extraño de lo que podemos pensar. " });

            migrationBuilder.InsertData(
                table: "Frase",
                columns: new[] { "Id", "Autor", "CategoriaId", "Fecha", "Texto" },
                values: new object[] { 324, "Frank Wilczek.", 3, new DateTime(2019, 11, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "En la física, no tienes que andar creándote problemas. La naturaleza lo hace por ti. " });

            migrationBuilder.InsertData(
                table: "Frase",
                columns: new[] { "Id", "Autor", "CategoriaId", "Fecha", "Texto" },
                values: new object[] { 323, "René Descartes.", 3, new DateTime(2019, 11, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "No acepto ningún principio físico que no sea también aceptado en las matemáticas. " });

            migrationBuilder.InsertData(
                table: "Frase",
                columns: new[] { "Id", "Autor", "CategoriaId", "Fecha", "Texto" },
                values: new object[] { 322, "John Gribbin.", 3, new DateTime(2019, 11, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Si los asuntos de la física alguna vez se acaban, el mundo será un lugar mucho menos interesante para vivir. " });

            migrationBuilder.InsertData(
                table: "Frase",
                columns: new[] { "Id", "Autor", "CategoriaId", "Fecha", "Texto" },
                values: new object[] { 321, "Edward Witten.", 3, new DateTime(2019, 11, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Incluso antes de la Teoría de Cuerdas, especialmente cuando la física se desarrolló en el siglo XX, resultó que las ecuaciones que realmente funcionan al describir la naturaleza con la mayor generalidad y la mayor simplicidad son muy elegantes y sutiles. " });

            migrationBuilder.InsertData(
                table: "Frase",
                columns: new[] { "Id", "Autor", "CategoriaId", "Fecha", "Texto" },
                values: new object[] { 320, "Wolfgang Pauli.", 3, new DateTime(2019, 11, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "He hecho algo terrible. He postulado una partícula que no puede ser detectada. " });

            migrationBuilder.InsertData(
                table: "Frase",
                columns: new[] { "Id", "Autor", "CategoriaId", "Fecha", "Texto" },
                values: new object[] { 319, "Victor Frederick Weisskopf.", 3, new DateTime(2019, 11, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Comprender el hidrógeno es comprender toda la física. " });

            migrationBuilder.InsertData(
                table: "Frase",
                columns: new[] { "Id", "Autor", "CategoriaId", "Fecha", "Texto" },
                values: new object[] { 329, "Peter Debye.", 3, new DateTime(2019, 11, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Si un problema está claramente planteado, ya no capta el interés de un físico. " });

            migrationBuilder.InsertData(
                table: "Frase",
                columns: new[] { "Id", "Autor", "CategoriaId", "Fecha", "Texto" },
                values: new object[] { 318, "Phillip F. Schewe.", 3, new DateTime(2019, 11, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Este es el Parque Jurásico para los físicos de partículas. El Gran Colisionador de Hadrones es una máquina del tiempo. " });

            migrationBuilder.InsertData(
                table: "Frase",
                columns: new[] { "Id", "Autor", "CategoriaId", "Fecha", "Texto" },
                values: new object[] { 316, "Arnold Sommerfeld.", 3, new DateTime(2019, 11, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Si quieres ser un físico, debes de hacer tres cosas. Primera, estudiar matemáticas, segunda, estudiar más matemáticas y tercera, hacer lo mismo. " });

            migrationBuilder.InsertData(
                table: "Frase",
                columns: new[] { "Id", "Autor", "CategoriaId", "Fecha", "Texto" },
                values: new object[] { 315, "Rudolph Ladenburg.", 3, new DateTime(2019, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Existían dos tipos de físicos en Berlín: por un lado estaba Einstein, y por el otro estaban todos los demás. " });

            migrationBuilder.InsertData(
                table: "Frase",
                columns: new[] { "Id", "Autor", "CategoriaId", "Fecha", "Texto" },
                values: new object[] { 314, "Erwin Schrödinger.", 3, new DateTime(2019, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "La física cuántica revela así una unidad básica del Universo. " });

            migrationBuilder.InsertData(
                table: "Frase",
                columns: new[] { "Id", "Autor", "CategoriaId", "Fecha", "Texto" },
                values: new object[] { 313, "Albert Einstein.", 3, new DateTime(2019, 11, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "La liberación del poder atómico ha cambiado todo excepto nuestra manera de pensar. La solución de este problema se encuentra en el corazón de las personas. Si lo hubiera sabido, me hubiera convertido en relojero. " });

            migrationBuilder.InsertData(
                table: "Frase",
                columns: new[] { "Id", "Autor", "CategoriaId", "Fecha", "Texto" },
                values: new object[] { 312, "Ashoke Sen.", 3, new DateTime(2019, 11, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dedicarse a la física es muy divertido si te gusta. " });

            migrationBuilder.InsertData(
                table: "Frase",
                columns: new[] { "Id", "Autor", "CategoriaId", "Fecha", "Texto" },
                values: new object[] { 311, "Peter Bergmann.", 3, new DateTime(2019, 11, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "En muchos aspectos, el físico teórico es como un filósofo en una vestimenta de trabajo. " });

            migrationBuilder.InsertData(
                table: "Frase",
                columns: new[] { "Id", "Autor", "CategoriaId", "Fecha", "Texto" },
                values: new object[] { 310, "Arthur Eddington.", 3, new DateTime(2019, 11, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "Es imposible poner a la física moderna a predecir algo con perfecto determinismo, ya que lidia con las probabilidades desde el principio. " });

            migrationBuilder.InsertData(
                table: "Frase",
                columns: new[] { "Id", "Autor", "CategoriaId", "Fecha", "Texto" },
                values: new object[] { 309, "Antony Garrett Lisi.", 3, new DateTime(2019, 11, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Lo que la física nos dice es que todo se resume en geometría y las interacciones de las partículas elementales. Y solo pueden ocurrir cosas si estas interacciones están perfectamente balanceadas. " });

            migrationBuilder.InsertData(
                table: "Frase",
                columns: new[] { "Id", "Autor", "CategoriaId", "Fecha", "Texto" },
                values: new object[] { 308, "Richard P. Feynman.", 3, new DateTime(2019, 11, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Para aquellos que quieren prueba alguna de que los físicos son humanos, la prueba está en la idiotez de todas las diferentes unidades que utilizan para medir la energía. " });

            migrationBuilder.InsertData(
                table: "Frase",
                columns: new[] { "Id", "Autor", "CategoriaId", "Fecha", "Texto" },
                values: new object[] { 317, "Lisa Randall.", 3, new DateTime(2019, 11, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "La creatividad es tan esencial para la física de partículas, la cosmología, las matemáticas y otros campos de la ciencia, como para sus beneficiarios más conocidos: las artes y las humanidades. " });

            migrationBuilder.InsertData(
                table: "Frase",
                columns: new[] { "Id", "Autor", "CategoriaId", "Fecha", "Texto" },
                values: new object[] { 189, "Jacob Bronowski.", 2, new DateTime(2019, 7, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Este es la esencia de la ciencia: hacer una pregunta impertinente, y así estarás en el camino hacia la respuesta pertinente." });

            migrationBuilder.InsertData(
                table: "Frase",
                columns: new[] { "Id", "Autor", "CategoriaId", "Fecha", "Texto" },
                values: new object[] { 188, "Carl Sagan.", 2, new DateTime(2019, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Si deseas hacer un pastel de manzana desde cero, primero debes inventar el universo." });

            migrationBuilder.InsertData(
                table: "Frase",
                columns: new[] { "Id", "Autor", "CategoriaId", "Fecha", "Texto" },
                values: new object[] { 187, "Carl Sagan.", 2, new DateTime(2019, 7, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "La ciencia no sólo es compatible con la espiritualidad; es una fuente profunda de espiritualidad." });

            migrationBuilder.InsertData(
                table: "Frase",
                columns: new[] { "Id", "Autor", "CategoriaId", "Fecha", "Texto" },
                values: new object[] { 67, "Niels Bohr.", 1, new DateTime(2019, 3, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "La tecnología ha avanzado más en los últimos treinta años que en los últimos doscientos. El avance exponencial sólo continuará." });

            migrationBuilder.InsertData(
                table: "Frase",
                columns: new[] { "Id", "Autor", "CategoriaId", "Fecha", "Texto" },
                values: new object[] { 66, "Jacques Ellul.", 1, new DateTime(2019, 3, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "La tecnología moderna se ha convertido en un fenómeno para la sociedad." });

            migrationBuilder.InsertData(
                table: "Frase",
                columns: new[] { "Id", "Autor", "CategoriaId", "Fecha", "Texto" },
                values: new object[] { 65, "", 1, new DateTime(2019, 3, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "Se ha convertido terriblemente obvio, que la tecnología ha sobrepasado nuestra humanidad." });

            migrationBuilder.InsertData(
                table: "Frase",
                columns: new[] { "Id", "Autor", "CategoriaId", "Fecha", "Texto" },
                values: new object[] { 64, "Ryan Bethencourt.", 1, new DateTime(2019, 3, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Nuestro mundo está creado en la biología y una vez que la entendamos, se convierte en tecnología." });

            migrationBuilder.InsertData(
                table: "Frase",
                columns: new[] { "Id", "Autor", "CategoriaId", "Fecha", "Texto" },
                values: new object[] { 63, "William S. Burroughs.", 1, new DateTime(2019, 3, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "El propósito de la tecnología no es confundir al cerebro, es ayudar al cuerpo." });

            migrationBuilder.InsertData(
                table: "Frase",
                columns: new[] { "Id", "Autor", "CategoriaId", "Fecha", "Texto" },
                values: new object[] { 62, "Demetri Martin.", 1, new DateTime(2019, 3, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Las cámaras digitales son un gran invento, porque nos permiten recordar grandes momentos." });

            migrationBuilder.InsertData(
                table: "Frase",
                columns: new[] { "Id", "Autor", "CategoriaId", "Fecha", "Texto" },
                values: new object[] { 61, "Muhammad Yunus.", 1, new DateTime(2019, 3, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "La tecnología es importante, pero lo único que realmente importa es qué hacemos con ella." });

            migrationBuilder.InsertData(
                table: "Frase",
                columns: new[] { "Id", "Autor", "CategoriaId", "Fecha", "Texto" },
                values: new object[] { 60, "Richard Stallman.", 1, new DateTime(2019, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Compartir es bueno y con la tecnología se vuelve más fácil." });

            migrationBuilder.InsertData(
                table: "Frase",
                columns: new[] { "Id", "Autor", "CategoriaId", "Fecha", "Texto" },
                values: new object[] { 59, "Marc Benioff.", 1, new DateTime(2019, 2, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Lo único que es seguro en la industria de la tecnología, es el cambio." });

            migrationBuilder.InsertData(
                table: "Frase",
                columns: new[] { "Id", "Autor", "CategoriaId", "Fecha", "Texto" },
                values: new object[] { 58, "Gertrude Stein.", 1, new DateTime(2019, 2, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Todos obtienen mucha información al día, tanta que se pierde el sentido común." });

            migrationBuilder.InsertData(
                table: "Frase",
                columns: new[] { "Id", "Autor", "CategoriaId", "Fecha", "Texto" },
                values: new object[] { 57, "Prince.", 1, new DateTime(2019, 2, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "La tecnología es cool, pero tienes que usarla sin que te use a ti." });

            migrationBuilder.InsertData(
                table: "Frase",
                columns: new[] { "Id", "Autor", "CategoriaId", "Fecha", "Texto" },
                values: new object[] { 56, "Simon Mainwaring.", 1, new DateTime(2019, 2, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Las redes sociales no son para explotar la tecnología, sino para servir a la sociedad." });

            migrationBuilder.InsertData(
                table: "Frase",
                columns: new[] { "Id", "Autor", "CategoriaId", "Fecha", "Texto" },
                values: new object[] { 55, "Arvind Gupta.", 1, new DateTime(2019, 2, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "La biología es la mejor tecnología. Siendo el ADN el software, las proteínas el hardware, y la células las fábricas." });

            migrationBuilder.InsertData(
                table: "Frase",
                columns: new[] { "Id", "Autor", "CategoriaId", "Fecha", "Texto" },
                values: new object[] { 54, "John Mackey.", 1, new DateTime(2019, 2, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "El turismo y la tecnología están conectando más al mundo." });

            migrationBuilder.InsertData(
                table: "Frase",
                columns: new[] { "Id", "Autor", "CategoriaId", "Fecha", "Texto" },
                values: new object[] { 53, "Rick Smolan.", 1, new DateTime(2019, 2, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Siempre llega una nueva herramienta. La tecnología es neutral, depende de cómo se use." });

            migrationBuilder.InsertData(
                table: "Frase",
                columns: new[] { "Id", "Autor", "CategoriaId", "Fecha", "Texto" },
                values: new object[] { 52, "David Wong.", 1, new DateTime(2019, 2, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "La tecnología nueva no es buena o mala. Tiene que ver con cómo las personas eliden usarla." });

            migrationBuilder.InsertData(
                table: "Frase",
                columns: new[] { "Id", "Autor", "CategoriaId", "Fecha", "Texto" },
                values: new object[] { 51, "Matt Mullenweg.", 1, new DateTime(2019, 2, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "La tecnología es mejor cuando junta a las personas." });

            migrationBuilder.InsertData(
                table: "Frase",
                columns: new[] { "Id", "Autor", "CategoriaId", "Fecha", "Texto" },
                values: new object[] { 50, "Anonimo", 1, new DateTime(2019, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sin tecnología no hay futuro para el hombre." });

            migrationBuilder.InsertData(
                table: "Frase",
                columns: new[] { "Id", "Autor", "CategoriaId", "Fecha", "Texto" },
                values: new object[] { 49, "Kevin Mitnick.", 1, new DateTime(2019, 2, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Algunas personas piensan que la tecnología tiene las respuestas." });

            migrationBuilder.InsertData(
                table: "Frase",
                columns: new[] { "Id", "Autor", "CategoriaId", "Fecha", "Texto" },
                values: new object[] { 68, "Emily Greene Balch.", 1, new DateTime(2019, 3, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "La tecnología nos facilita reducir las barreras de la distancia y el tiempo." });

            migrationBuilder.InsertData(
                table: "Frase",
                columns: new[] { "Id", "Autor", "CategoriaId", "Fecha", "Texto" },
                values: new object[] { 69, "Henry David Thoreau.", 1, new DateTime(2019, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "El hombre se ha vuelto la herramienta de sus herramientas." });

            migrationBuilder.InsertData(
                table: "Frase",
                columns: new[] { "Id", "Autor", "CategoriaId", "Fecha", "Texto" },
                values: new object[] { 70, "James Comey.", 1, new DateTime(2019, 3, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "La tecnología ha cambiado la forma de vivir desde siempre. Estamos interconectados, de una forma u otra." });

            migrationBuilder.InsertData(
                table: "Frase",
                columns: new[] { "Id", "Autor", "CategoriaId", "Fecha", "Texto" },
                values: new object[] { 71, "Dean Kamen.", 1, new DateTime(2019, 3, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "De vez en cuando, una nueva tecnología, un viejo problema, junto con una gran idea, se convierten en innovación." });

            migrationBuilder.InsertData(
                table: "Frase",
                columns: new[] { "Id", "Autor", "CategoriaId", "Fecha", "Texto" },
                values: new object[] { 91, "Jeff Pesis.", 1, new DateTime(2019, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "El hardware es esa parte de la computadora que puedes patear." });

            migrationBuilder.InsertData(
                table: "Frase",
                columns: new[] { "Id", "Autor", "CategoriaId", "Fecha", "Texto" },
                values: new object[] { 90, "Volker Grassmuck.", 1, new DateTime(2019, 3, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "La promesa definitiva de la tecnología es volvernos los maestros de un mundo que podemos controlar presionando un botón." });

            migrationBuilder.InsertData(
                table: "Frase",
                columns: new[] { "Id", "Autor", "CategoriaId", "Fecha", "Texto" },
                values: new object[] { 89, "Douglas Coupland.", 1, new DateTime(2019, 3, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "La televisión e internet son grandes formas de mantener a la gente estúpida sin salir a hacer el ridículo." });

            migrationBuilder.InsertData(
                table: "Frase",
                columns: new[] { "Id", "Autor", "CategoriaId", "Fecha", "Texto" },
                values: new object[] { 88, "Joseph Wood Krutch.", 1, new DateTime(2019, 3, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "La tecnología hace posibles grandes masas, las grandes masas hacen a la tecnología indispensable." });

            migrationBuilder.InsertData(
                table: "Frase",
                columns: new[] { "Id", "Autor", "CategoriaId", "Fecha", "Texto" },
                values: new object[] { 87, "Albert Einstein.", 1, new DateTime(2019, 3, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "El espíritu humano debe dominar ante la tecnología." });

            migrationBuilder.InsertData(
                table: "Frase",
                columns: new[] { "Id", "Autor", "CategoriaId", "Fecha", "Texto" },
                values: new object[] { 86, "Larry Niven.", 1, new DateTime(2019, 3, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "La ética cambia con la tecnología." });

            migrationBuilder.InsertData(
                table: "Frase",
                columns: new[] { "Id", "Autor", "CategoriaId", "Fecha", "Texto" },
                values: new object[] { 85, "George W. Bush.", 1, new DateTime(2019, 3, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "En estos días, hay cámaras hechas para ver la diferencia entre una ardilla y una bomba." });

            migrationBuilder.InsertData(
                table: "Frase",
                columns: new[] { "Id", "Autor", "CategoriaId", "Fecha", "Texto" },
                values: new object[] { 84, "Kevin Kelly.", 1, new DateTime(2019, 3, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Los humanos son los órganos reproductores de la tecnología." });

            migrationBuilder.InsertData(
                table: "Frase",
                columns: new[] { "Id", "Autor", "CategoriaId", "Fecha", "Texto" },
                values: new object[] { 83, "Julie Kagawa.", 1, new DateTime(2019, 3, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mientras las ciudades crecen, y la tecnología se esparce por el mundo, la creencia y la imaginación se desvanece con nosotros." });

            migrationBuilder.InsertData(
                table: "Frase",
                columns: new[] { "Id", "Autor", "CategoriaId", "Fecha", "Texto" },
                values: new object[] { 48, "Deepak Chopra.", 1, new DateTime(2019, 2, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Siempre he sentido que la tecnología puede ser usada para nuestro beneficio y debería ser usada para nuestro beneficio." });

            migrationBuilder.InsertData(
                table: "Frase",
                columns: new[] { "Id", "Autor", "CategoriaId", "Fecha", "Texto" },
                values: new object[] { 82, "Dan Brown.", 1, new DateTime(2019, 3, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Incluso la tecnología, que debería unirnos, nos divide. Todo estamos conectados, pero aun así nos sentimos solos." });

            migrationBuilder.InsertData(
                table: "Frase",
                columns: new[] { "Id", "Autor", "CategoriaId", "Fecha", "Texto" },
                values: new object[] { 80, "Nadine Gordimer.", 1, new DateTime(2019, 3, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "Los libros no requieren baterías." });

            migrationBuilder.InsertData(
                table: "Frase",
                columns: new[] { "Id", "Autor", "CategoriaId", "Fecha", "Texto" },
                values: new object[] { 79, "Karl Lagerfeld.", 1, new DateTime(2019, 3, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "El iPod cambió completamente el acercamiento de la gente hacia la música." });

            migrationBuilder.InsertData(
                table: "Frase",
                columns: new[] { "Id", "Autor", "CategoriaId", "Fecha", "Texto" },
                values: new object[] { 78, "Agatha Christie.", 1, new DateTime(2019, 3, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Errar es humano, pero las máquinas, por más que lo intenten, son incapaces de errar como el humano." });

            migrationBuilder.InsertData(
                table: "Frase",
                columns: new[] { "Id", "Autor", "CategoriaId", "Fecha", "Texto" },
                values: new object[] { 77, "Pablo Picasso.", 1, new DateTime(2019, 3, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Las computadoras son inútiles. Sólo saben darte respuestas." });

            migrationBuilder.InsertData(
                table: "Frase",
                columns: new[] { "Id", "Autor", "CategoriaId", "Fecha", "Texto" },
                values: new object[] { 76, "Phillip K. Dick.", 1, new DateTime(2019, 3, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Eventualmente no diremos «me están espiando desde mi teléfono’’, sino «mi teléfono me está espiando’’." });

            migrationBuilder.InsertData(
                table: "Frase",
                columns: new[] { "Id", "Autor", "CategoriaId", "Fecha", "Texto" },
                values: new object[] { 75, "Patti Smith.", 1, new DateTime(2019, 3, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "No importa qué tantos avances tecnológicos haya, no abandonemos los libros. Son lo más bonito en nuestro mundo." });

            migrationBuilder.InsertData(
                table: "Frase",
                columns: new[] { "Id", "Autor", "CategoriaId", "Fecha", "Texto" },
                values: new object[] { 74, "Terry Pratchett.", 1, new DateTime(2019, 3, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sigue siendo magia aunque sepas cómo se hace." });

            migrationBuilder.InsertData(
                table: "Frase",
                columns: new[] { "Id", "Autor", "CategoriaId", "Fecha", "Texto" },
                values: new object[] { 73, "R. Buckminster Fuller.", 1, new DateTime(2019, 3, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "La humanidad ha adquirido toda la tecnología correcta por los motivos incorrectos." });

            migrationBuilder.InsertData(
                table: "Frase",
                columns: new[] { "Id", "Autor", "CategoriaId", "Fecha", "Texto" },
                values: new object[] { 72, "Thomas Edison.", 1, new DateTime(2019, 3, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sólo porque algo no hizo lo que esperabas, no significa que sea inútil." });

            migrationBuilder.InsertData(
                table: "Frase",
                columns: new[] { "Id", "Autor", "CategoriaId", "Fecha", "Texto" },
                values: new object[] { 81, "Jefferson Bethke.", 1, new DateTime(2019, 3, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Nos rehusamos a apagar nuestras computadoras, nuestros teléfonos y sentarnos en silencio, porque en esos momentos tenemos que hacerle frente a lo que realmente somos." });

            migrationBuilder.InsertData(
                table: "Frase",
                columns: new[] { "Id", "Autor", "CategoriaId", "Fecha", "Texto" },
                values: new object[] { 92, "Omar N. Bradley.", 1, new DateTime(2019, 4, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Si continuamos expandiendo nuestra industria tecnológica sin sabiduría o responsabilidad, nuestro sirviente podría convertirse en nuestro ejecutor." });

            migrationBuilder.InsertData(
                table: "Frase",
                columns: new[] { "Id", "Autor", "CategoriaId", "Fecha", "Texto" },
                values: new object[] { 47, "Clive James.", 1, new DateTime(2019, 2, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Es sólo cuando las cosas salen mal que las máquinas te recuerdan lo poderosas que son." });

            migrationBuilder.InsertData(
                table: "Frase",
                columns: new[] { "Id", "Autor", "CategoriaId", "Fecha", "Texto" },
                values: new object[] { 45, "Ursula K. Le Guin.", 1, new DateTime(2019, 2, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Si la ciencia ficción es la mitología de la tecnología moderna, entonces su mito es trágico." });

            migrationBuilder.InsertData(
                table: "Frase",
                columns: new[] { "Id", "Autor", "CategoriaId", "Fecha", "Texto" },
                values: new object[] { 20, "Tim Berners Lee", 1, new DateTime(2019, 1, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "No podemos culpar a la tecnología cuando comete errores." });

            migrationBuilder.InsertData(
                table: "Frase",
                columns: new[] { "Id", "Autor", "CategoriaId", "Fecha", "Texto" },
                values: new object[] { 19, "Erich Fromm.", 1, new DateTime(2019, 1, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "La educación fabrica máquinas que actúan como hombres y produce hombres que actúan como máquinas. " });

            migrationBuilder.InsertData(
                table: "Frase",
                columns: new[] { "Id", "Autor", "CategoriaId", "Fecha", "Texto" },
                values: new object[] { 18, "Libby Larsen.", 1, new DateTime(2019, 1, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "El gran mito de nuestro tiempo es que la tecnología es la comunicación." });

            migrationBuilder.InsertData(
                table: "Frase",
                columns: new[] { "Id", "Autor", "CategoriaId", "Fecha", "Texto" },
                values: new object[] { 17, "Sydney J. Harris.", 1, new DateTime(2019, 1, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "El verdadero peligro no es que las computadoras comenzarán a pensar como los hombres, sino que los hombres comenzarán a pensar como las computadoras." });

            migrationBuilder.InsertData(
                table: "Frase",
                columns: new[] { "Id", "Autor", "CategoriaId", "Fecha", "Texto" },
                values: new object[] { 16, "Larry Page.", 1, new DateTime(2019, 1, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Especialmente en la tecnología, necesitamos cambios revolucionarios, no cambios incrementales." });

            migrationBuilder.InsertData(
                table: "Frase",
                columns: new[] { "Id", "Autor", "CategoriaId", "Fecha", "Texto" },
                values: new object[] { 15, "Northrop Frye.", 1, new DateTime(2019, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "La máquina tecnológicamente más eficiente que el hombre ha inventado es el libro." });

            migrationBuilder.InsertData(
                table: "Frase",
                columns: new[] { "Id", "Autor", "CategoriaId", "Fecha", "Texto" },
                values: new object[] { 14, "Jan C. Ting.", 1, new DateTime(2019, 1, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "La tecnología y la robótica están avanzando y reducirán la necesidad de trabajadores en el futuro." });

            migrationBuilder.InsertData(
                table: "Frase",
                columns: new[] { "Id", "Autor", "CategoriaId", "Fecha", "Texto" },
                values: new object[] { 13, "Douglas Coupland.", 1, new DateTime(2019, 1, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Incluso cuando te tomas unas vacaciones de la tecnología, la tecnología no se toma un descanso de ti." });

            migrationBuilder.InsertData(
                table: "Frase",
                columns: new[] { "Id", "Autor", "CategoriaId", "Fecha", "Texto" },
                values: new object[] { 12, "Andrew Brown.", 1, new DateTime(2019, 1, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "El Internet es tan grande, tan poderoso y sin sentido que para algunas personas es un sustituto completo para toda la vida." });

            migrationBuilder.InsertData(
                table: "Frase",
                columns: new[] { "Id", "Autor", "CategoriaId", "Fecha", "Texto" },
                values: new object[] { 11, "Bill Gates.", 1, new DateTime(2019, 1, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "La tecnología es sólo una herramienta. En términos de llevar a los niños a trabajar juntos y motivarlos, el profesor es el más importante." });

            migrationBuilder.InsertData(
                table: "Frase",
                columns: new[] { "Id", "Autor", "CategoriaId", "Fecha", "Texto" },
                values: new object[] { 10, "Albert Einstein.", 1, new DateTime(2019, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "El espíritu humano debe prevalecer sobre la tecnología." });

            migrationBuilder.InsertData(
                table: "Frase",
                columns: new[] { "Id", "Autor", "CategoriaId", "Fecha", "Texto" },
                values: new object[] { 9, "Alvin Toffler.", 1, new DateTime(2019, 1, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "El gran motor del cambio – la tecnología." });

            migrationBuilder.InsertData(
                table: "Frase",
                columns: new[] { "Id", "Autor", "CategoriaId", "Fecha", "Texto" },
                values: new object[] { 8, "B. F. Skinner.", 1, new DateTime(2019, 1, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "El problema real no es si las máquinas piensan, sino si lo hacen los hombres." });

            migrationBuilder.InsertData(
                table: "Frase",
                columns: new[] { "Id", "Autor", "CategoriaId", "Fecha", "Texto" },
                values: new object[] { 7, "Edward Teller.", 1, new DateTime(2019, 1, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "La ciencia de hoy es la tecnología del mañana." });

            migrationBuilder.InsertData(
                table: "Frase",
                columns: new[] { "Id", "Autor", "CategoriaId", "Fecha", "Texto" },
                values: new object[] { 6, "Albert Einstein.", 1, new DateTime(2019, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "Se ha vuelto terriblemente obvio que nuestra tecnología ha superado nuestra humanidad." });

            migrationBuilder.InsertData(
                table: "Frase",
                columns: new[] { "Id", "Autor", "CategoriaId", "Fecha", "Texto" },
                values: new object[] { 5, "Alvin Toffler.", 1, new DateTime(2019, 1, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "La tecnología se alimenta a si misma. La tecnología hace posible más tecnología." });

            migrationBuilder.InsertData(
                table: "Frase",
                columns: new[] { "Id", "Autor", "CategoriaId", "Fecha", "Texto" },
                values: new object[] { 4, "Steve Jobs.", 1, new DateTime(2019, 1, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "La tecnología no es nada. Lo importante es que tengas fe en la gente, que sean básicamente buenas e inteligentes, y si les das herramientas, harán cosas maravillosas con ellas." });

            migrationBuilder.InsertData(
                table: "Frase",
                columns: new[] { "Id", "Autor", "CategoriaId", "Fecha", "Texto" },
                values: new object[] { 3, "Marcos McKinnon.", 1, new DateTime(2019, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "La tecnología y las redes sociales han traído el poder a la gente." });

            migrationBuilder.InsertData(
                table: "Frase",
                columns: new[] { "Id", "Autor", "CategoriaId", "Fecha", "Texto" },
                values: new object[] { 2, "Christian Lous Lange.", 1, new DateTime(2019, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "La tecnología es un siervo útil, pero un amo peligroso." });

            migrationBuilder.InsertData(
                table: "Frase",
                columns: new[] { "Id", "Autor", "CategoriaId", "Fecha", "Texto" },
                values: new object[] { 21, "Aldous Huxley.", 1, new DateTime(2019, 1, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "El progreso tecnológico sólo nos ha proporcionado medios más eficientes para ir hacia atrás." });

            migrationBuilder.InsertData(
                table: "Frase",
                columns: new[] { "Id", "Autor", "CategoriaId", "Fecha", "Texto" },
                values: new object[] { 22, "Alan Watts.", 1, new DateTime(2019, 1, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "La tecnología es destructiva sólo en las manos de las personas que no se dan cuenta de que son uno y que están en el mismo proceso que el universo." });

            migrationBuilder.InsertData(
                table: "Frase",
                columns: new[] { "Id", "Autor", "CategoriaId", "Fecha", "Texto" },
                values: new object[] { 23, "Simon Mainwaring.", 1, new DateTime(2019, 1, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "La tecnología nos está enseñando a ser humanos de nuevo." });

            migrationBuilder.InsertData(
                table: "Frase",
                columns: new[] { "Id", "Autor", "CategoriaId", "Fecha", "Texto" },
                values: new object[] { 24, "Karl Marx.", 1, new DateTime(2019, 1, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "La producción de demasiadas cosas útiles da lugar a demasiadas personas inútiles." });

            migrationBuilder.InsertData(
                table: "Frase",
                columns: new[] { "Id", "Autor", "CategoriaId", "Fecha", "Texto" },
                values: new object[] { 44, "Sam Ewing.", 1, new DateTime(2019, 2, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Los ordenadores son como los bikinis. Ahorran a la gente un montón de conjeturas." });

            migrationBuilder.InsertData(
                table: "Frase",
                columns: new[] { "Id", "Autor", "CategoriaId", "Fecha", "Texto" },
                values: new object[] { 43, "Marshall McLuhan.", 1, new DateTime(2019, 2, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "A medida que avanza la tecnología, revierte las características de cada situación una y otra vez. La edad de lo automático va a ser la edad de «hazlo tú mismo»." });

            migrationBuilder.InsertData(
                table: "Frase",
                columns: new[] { "Id", "Autor", "CategoriaId", "Fecha", "Texto" },
                values: new object[] { 42, "Richard Stallman.", 1, new DateTime(2019, 2, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Compartir es bueno, y con la tecnología digital, compartir es sencillo." });

            migrationBuilder.InsertData(
                table: "Frase",
                columns: new[] { "Id", "Autor", "CategoriaId", "Fecha", "Texto" },
                values: new object[] { 41, "Laurie Anderson.", 1, new DateTime(2019, 2, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "La tecnología es la hoguera alrededor de la cual nos contamos nuestras historias." });

            migrationBuilder.InsertData(
                table: "Frase",
                columns: new[] { "Id", "Autor", "CategoriaId", "Fecha", "Texto" },
                values: new object[] { 40, "Larry Niven.", 1, new DateTime(2019, 2, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "La ética cambia con la tecnología." });

            migrationBuilder.InsertData(
                table: "Frase",
                columns: new[] { "Id", "Autor", "CategoriaId", "Fecha", "Texto" },
                values: new object[] { 39, "Jared Diamond.", 1, new DateTime(2019, 2, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "La tecnología tiene que ser inventada o adoptada." });

            migrationBuilder.InsertData(
                table: "Frase",
                columns: new[] { "Id", "Autor", "CategoriaId", "Fecha", "Texto" },
                values: new object[] { 38, "Douglas Adams.", 1, new DateTime(2019, 2, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Estamos atrapados con la tecnología cuando lo que realmente queremos son sólo cosas que funcionan." });

            migrationBuilder.InsertData(
                table: "Frase",
                columns: new[] { "Id", "Autor", "CategoriaId", "Fecha", "Texto" },
                values: new object[] { 37, "John Lasseter.", 1, new DateTime(2019, 2, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "El arte se opone a la tecnología, y la tecnología inspira al arte." });

            migrationBuilder.InsertData(
                table: "Frase",
                columns: new[] { "Id", "Autor", "CategoriaId", "Fecha", "Texto" },
                values: new object[] { 36, "Steve Jobs.", 1, new DateTime(2019, 2, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "No es fe en la tecnología. Es fe en la gente." });

            migrationBuilder.InsertData(
                table: "Frase",
                columns: new[] { "Id", "Autor", "CategoriaId", "Fecha", "Texto" },
                values: new object[] { 46, "Tom Hodgkinson.", 1, new DateTime(2019, 2, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Toda nuestra tecnología es completamente innecesaria para una vida feliz." });

            migrationBuilder.InsertData(
                table: "Frase",
                columns: new[] { "Id", "Autor", "CategoriaId", "Fecha", "Texto" },
                values: new object[] { 35, "Alan M. Eddison.", 1, new DateTime(2019, 2, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "La tecnología moderna debe a la ecología una disculpa." });

            migrationBuilder.InsertData(
                table: "Frase",
                columns: new[] { "Id", "Autor", "CategoriaId", "Fecha", "Texto" },
                values: new object[] { 33, "Joseph Wood Krutch.", 1, new DateTime(2019, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "La tecnología hizo posible las largas poblaciones; las largas poblaciones hacen ahora a la tecnología indispensable." });

            migrationBuilder.InsertData(
                table: "Frase",
                columns: new[] { "Id", "Autor", "CategoriaId", "Fecha", "Texto" },
                values: new object[] { 32, "Talib Kweli.", 1, new DateTime(2019, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Tienes que aprender a aprovechar la tecnología para poder usarla para cosas positivas sin estar desconectado de la naturaleza." });

            migrationBuilder.InsertData(
                table: "Frase",
                columns: new[] { "Id", "Autor", "CategoriaId", "Fecha", "Texto" },
                values: new object[] { 31, "Vernor Vinge.", 1, new DateTime(2019, 1, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Tanto tecnología, tan poco talento." });

            migrationBuilder.InsertData(
                table: "Frase",
                columns: new[] { "Id", "Autor", "CategoriaId", "Fecha", "Texto" },
                values: new object[] { 30, "Margaret Atwood.", 1, new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Cada aspecto de la tecnología humana tiene un lado oscuro, incluyendo el arco y la flecha." });

            migrationBuilder.InsertData(
                table: "Frase",
                columns: new[] { "Id", "Autor", "CategoriaId", "Fecha", "Texto" },
                values: new object[] { 29, "Arthur M. Schlesinger.", 1, new DateTime(2019, 1, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "La ciencia y la tecnología revolucionan nuestras vidas, pero la memoria, la tradición y el mito enmarcan nuestra respuestas." });

            migrationBuilder.InsertData(
                table: "Frase",
                columns: new[] { "Id", "Autor", "CategoriaId", "Fecha", "Texto" },
                values: new object[] { 28, "Douglas Adams.", 1, new DateTime(2019, 1, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "La tecnología es una palabra que describe algo que no funciona todavía." });

            migrationBuilder.InsertData(
                table: "Frase",
                columns: new[] { "Id", "Autor", "CategoriaId", "Fecha", "Texto" },
                values: new object[] { 27, "Elbert Hubbard.", 1, new DateTime(2019, 1, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Una máquina puede hacer el trabajo de cincuenta hombres ordinarios. Ninguna máquina puede hacer el trabajo de un hombre extraordinario." });

            migrationBuilder.InsertData(
                table: "Frase",
                columns: new[] { "Id", "Autor", "CategoriaId", "Fecha", "Texto" },
                values: new object[] { 26, "Alan Moore.", 1, new DateTime(2019, 1, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "La tecnología es siempre un arma de doble filo. Traerá muchos beneficios, pero también muchos desastres." });

            migrationBuilder.InsertData(
                table: "Frase",
                columns: new[] { "Id", "Autor", "CategoriaId", "Fecha", "Texto" },
                values: new object[] { 25, "Matt Mullenweg.", 1, new DateTime(2019, 1, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "La tecnología es mejor cuando reúne a la gente." });

            migrationBuilder.InsertData(
                table: "Frase",
                columns: new[] { "Id", "Autor", "CategoriaId", "Fecha", "Texto" },
                values: new object[] { 34, "Bill Watterson.", 1, new DateTime(2019, 2, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Toda esta tecnología moderna sólo hace que la gente trate de hacer todo a la vez." });

            migrationBuilder.InsertData(
                table: "Frase",
                columns: new[] { "Id", "Autor", "CategoriaId", "Fecha", "Texto" },
                values: new object[] { 93, "Jared Diamond.", 1, new DateTime(2019, 4, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "La tecnología la inventamos o la adoptamos." });

            migrationBuilder.InsertData(
                table: "Frase",
                columns: new[] { "Id", "Autor", "CategoriaId", "Fecha", "Texto" },
                values: new object[] { 94, "Alan Kay.", 1, new DateTime(2019, 4, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "La tecnología no es nada de lo que era cuando nacimos." });

            migrationBuilder.InsertData(
                table: "Frase",
                columns: new[] { "Id", "Autor", "CategoriaId", "Fecha", "Texto" },
                values: new object[] { 95, "Cory Doctorow.", 1, new DateTime(2019, 4, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Por esto amo la tecnología; sí la usas bien, puede darte poder y privacidad." });

            migrationBuilder.InsertData(
                table: "Frase",
                columns: new[] { "Id", "Autor", "CategoriaId", "Fecha", "Texto" },
                values: new object[] { 162, "Friedrich Schiller.", 2, new DateTime(2019, 6, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "La ciencia para unos es la gran deidad celeste; para los demás, una buena vaca que les proporciona mantequilla." });

            migrationBuilder.InsertData(
                table: "Frase",
                columns: new[] { "Id", "Autor", "CategoriaId", "Fecha", "Texto" },
                values: new object[] { 161, "Li Po.", 2, new DateTime(2019, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "La ciencia produce el deseo, que produce la lucha, que produce el sufrimiento." });

            migrationBuilder.InsertData(
                table: "Frase",
                columns: new[] { "Id", "Autor", "CategoriaId", "Fecha", "Texto" },
                values: new object[] { 160, "Piotr Alekseevich.", 2, new DateTime(2019, 6, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "La ciencia hace verdaderos progresos cuando una verdad nueva encuentra un ambiente preparado para acogerla." });

            migrationBuilder.InsertData(
                table: "Frase",
                columns: new[] { "Id", "Autor", "CategoriaId", "Fecha", "Texto" },
                values: new object[] { 159, "Arthur Koestler.", 2, new DateTime(2019, 6, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Cuanto más original es un descubrimiento, más obvio parece después." });

            migrationBuilder.InsertData(
                table: "Frase",
                columns: new[] { "Id", "Autor", "CategoriaId", "Fecha", "Texto" },
                values: new object[] { 158, "George Henry Lewes.", 2, new DateTime(2019, 6, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "La ciencia es la clasificación sistemática de la experiencia." });

            migrationBuilder.InsertData(
                table: "Frase",
                columns: new[] { "Id", "Autor", "CategoriaId", "Fecha", "Texto" },
                values: new object[] { 157, "Richard Clarke Cabot.", 2, new DateTime(2019, 6, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "La ética y la ciencia necesitan darse la mano." });

            migrationBuilder.InsertData(
                table: "Frase",
                columns: new[] { "Id", "Autor", "CategoriaId", "Fecha", "Texto" },
                values: new object[] { 156, "Martin H. Fischer.", 2, new DateTime(2019, 6, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Los grandes hombres de la ciencia son artistas supremos." });

            migrationBuilder.InsertData(
                table: "Frase",
                columns: new[] { "Id", "Autor", "CategoriaId", "Fecha", "Texto" },
                values: new object[] { 155, "Richard Pawson.", 2, new DateTime(2019, 6, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "La ciencia más peligrosa es aquella que ésta restringida al dominio de los expertos." });

            migrationBuilder.InsertData(
                table: "Frase",
                columns: new[] { "Id", "Autor", "CategoriaId", "Fecha", "Texto" },
                values: new object[] { 154, "José Ortega y Gasset.", 2, new DateTime(2019, 6, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "La ciencia es todo aquello sobre lo cual siempre cabe discusión." });

            migrationBuilder.InsertData(
                table: "Frase",
                columns: new[] { "Id", "Autor", "CategoriaId", "Fecha", "Texto" },
                values: new object[] { 153, "Platón.", 2, new DateTime(2019, 6, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "En torno de la esencia está la morada de la ciencia." });

            migrationBuilder.InsertData(
                table: "Frase",
                columns: new[] { "Id", "Autor", "CategoriaId", "Fecha", "Texto" },
                values: new object[] { 152, "Sigmund Freud.", 2, new DateTime(2019, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "La ciencia moderna aún no ha producido un medicamento tranquilizador tan eficaz como unas pocas palabras bondadosas." });

            migrationBuilder.InsertData(
                table: "Frase",
                columns: new[] { "Id", "Autor", "CategoriaId", "Fecha", "Texto" },
                values: new object[] { 151, "Marcus Jacobson.", 2, new DateTime(2019, 5, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "La ciencia puede descubrir lo que es cierto, pero no lo que es bueno, justo y humano." });

            migrationBuilder.InsertData(
                table: "Frase",
                columns: new[] { "Id", "Autor", "CategoriaId", "Fecha", "Texto" },
                values: new object[] { 150, "Julio Verne.", 2, new DateTime(2019, 5, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "La ciencia se compone de errores, que, a su vez, son los pasos hacia la verdad." });

            migrationBuilder.InsertData(
                table: "Frase",
                columns: new[] { "Id", "Autor", "CategoriaId", "Fecha", "Texto" },
                values: new object[] { 149, "André Breton.", 2, new DateTime(2019, 5, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Toda idea que triunfa marcha hasta su perdición." });

            migrationBuilder.InsertData(
                table: "Frase",
                columns: new[] { "Id", "Autor", "CategoriaId", "Fecha", "Texto" },
                values: new object[] { 148, "Miguel de Unamuno.", 2, new DateTime(2019, 5, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "La verdadera ciencia enseña, sobre todo, a dudar y a ser ignorante." });

            migrationBuilder.InsertData(
                table: "Frase",
                columns: new[] { "Id", "Autor", "CategoriaId", "Fecha", "Texto" },
                values: new object[] { 147, "Georg Wilhem Friedrich Hegel.", 2, new DateTime(2019, 5, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "La ciencia es un círculo cerrado sobre sí mismo, un círculo de círculos." });

            migrationBuilder.InsertData(
                table: "Frase",
                columns: new[] { "Id", "Autor", "CategoriaId", "Fecha", "Texto" },
                values: new object[] { 146, "Lemait.", 2, new DateTime(2019, 5, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "La ciencia es el cementerio de las hipótesis." });

            migrationBuilder.InsertData(
                table: "Frase",
                columns: new[] { "Id", "Autor", "CategoriaId", "Fecha", "Texto" },
                values: new object[] { 145, "Ralph WaldoEmerson.", 2, new DateTime(2019, 5, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "La ciencia rivaliza con la mitología en milagros." });

            migrationBuilder.InsertData(
                table: "Frase",
                columns: new[] { "Id", "Autor", "CategoriaId", "Fecha", "Texto" },
                values: new object[] { 144, "León Tolstoi.", 2, new DateTime(2019, 5, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "Una ciencia, es decir, un conocimiento imaginario de la verdad absoluta." });

            migrationBuilder.InsertData(
                table: "Frase",
                columns: new[] { "Id", "Autor", "CategoriaId", "Fecha", "Texto" },
                values: new object[] { 163, "Alfred Tennyson.", 2, new DateTime(2019, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "La ciencia viene, la sabiduría se queda." });

            migrationBuilder.InsertData(
                table: "Frase",
                columns: new[] { "Id", "Autor", "CategoriaId", "Fecha", "Texto" },
                values: new object[] { 164, "J.Robert Oppenheimer.", 2, new DateTime(2019, 6, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "En el campo de la ciencia aprendemos cuán grande es la extrañeza del mundo." });

            migrationBuilder.InsertData(
                table: "Frase",
                columns: new[] { "Id", "Autor", "CategoriaId", "Fecha", "Texto" },
                values: new object[] { 165, "Georg Simmel.", 2, new DateTime(2019, 6, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "La ciencia que la humanidad tiene en un momento dado depende de lo que es la humanidad en ese momento." });

            migrationBuilder.InsertData(
                table: "Frase",
                columns: new[] { "Id", "Autor", "CategoriaId", "Fecha", "Texto" },
                values: new object[] { 166, "Leónidas Andreiev.", 2, new DateTime(2019, 6, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "La ciencia es el misticismo de los hechos; la verdad es que nadie sabe nada." });

            migrationBuilder.InsertData(
                table: "Frase",
                columns: new[] { "Id", "Autor", "CategoriaId", "Fecha", "Texto" },
                values: new object[] { 186, "Charles Darwin.", 2, new DateTime(2019, 7, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Un hombre que se atreve a perder una hora de tiempo no ha descubierto el valor de la vida." });

            migrationBuilder.InsertData(
                table: "Frase",
                columns: new[] { "Id", "Autor", "CategoriaId", "Fecha", "Texto" },
                values: new object[] { 185, "Christopher Hitchens.", 2, new DateTime(2019, 7, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Lo que se puede afirmar sin evidencia, puede ser descartado sin evidencia." });

            migrationBuilder.InsertData(
                table: "Frase",
                columns: new[] { "Id", "Autor", "CategoriaId", "Fecha", "Texto" },
                values: new object[] { 184, "Terry Pratchett.", 2, new DateTime(2019, 7, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Al principio, sólo era la nada, la cual explotó." });

            migrationBuilder.InsertData(
                table: "Frase",
                columns: new[] { "Id", "Autor", "CategoriaId", "Fecha", "Texto" },
                values: new object[] { 183, "Dan Brown.", 2, new DateTime(2019, 7, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "La ciencia y la religión no están en desacuerdo. La ciencia es demasiado joven para entender." });

            migrationBuilder.InsertData(
                table: "Frase",
                columns: new[] { "Id", "Autor", "CategoriaId", "Fecha", "Texto" },
                values: new object[] { 182, "Niels Bohr.", 2, new DateTime(2019, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Un experto es una persona que ha cometido todos los errores que pueden hacerse en un campo muy estrecho." });

            migrationBuilder.InsertData(
                table: "Frase",
                columns: new[] { "Id", "Autor", "CategoriaId", "Fecha", "Texto" },
                values: new object[] { 181, "Arthur C. Clarke.", 2, new DateTime(2019, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Estoy seguro de que el universo está lleno de vida inteligente. Es sólo que es demasiado inteligente para venir aquí." });

            migrationBuilder.InsertData(
                table: "Frase",
                columns: new[] { "Id", "Autor", "CategoriaId", "Fecha", "Texto" },
                values: new object[] { 180, "Stephen Hawking.", 2, new DateTime(2019, 6, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Somos una raza avanzada de monos en un planeta menor en una estrella muy promedio. Pero podemos entender el Universo. Eso nos convierte en algo muy especial." });

            migrationBuilder.InsertData(
                table: "Frase",
                columns: new[] { "Id", "Autor", "CategoriaId", "Fecha", "Texto" },
                values: new object[] { 179, "Marie Curie.", 2, new DateTime(2019, 6, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "No debemos olvidar que cuando se descubrió el radio nadie sabía que sería útil en los hospitales. El trabajo era de ciencia pura. Y esta es una prueba de que el trabajo científico no debe considerarse desde el punto de vista de su utilidad directa. Debe hacerse por sí mismo, por la belleza de la ciencia, y entonces siempre existe la posibilidad de que un descubrimiento científico se convierta en un beneficio para la humanidad." });

            migrationBuilder.InsertData(
                table: "Frase",
                columns: new[] { "Id", "Autor", "CategoriaId", "Fecha", "Texto" },
                values: new object[] { 178, "Carl Sagan.", 2, new DateTime(2019, 6, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "En algún lugar algo increíble está esperando a ser descubierto." });

            migrationBuilder.InsertData(
                table: "Frase",
                columns: new[] { "Id", "Autor", "CategoriaId", "Fecha", "Texto" },
                values: new object[] { 143, "Emilé Zola.", 2, new DateTime(2019, 5, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "¿La ciencia ha prometido la felicidad? No lo creo. Ha prometido la verdad y la cuestión es saber si con la verdad se conseguirá algún día la felicidad." });

            migrationBuilder.InsertData(
                table: "Frase",
                columns: new[] { "Id", "Autor", "CategoriaId", "Fecha", "Texto" },
                values: new object[] { 177, "Martin Luther King Jr.", 2, new DateTime(2019, 6, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "Nuestro poder científico ha superado nuestro poder espiritual. Hemos guiado misiles y malguiado a hombres." });

            migrationBuilder.InsertData(
                table: "Frase",
                columns: new[] { "Id", "Autor", "CategoriaId", "Fecha", "Texto" },
                values: new object[] { 175, "Bertrand Russell.", 2, new DateTime(2019, 6, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "Los científicos se esfuerzan por hacer posible lo imposible. Los políticos por hacer lo posible imposible." });

            migrationBuilder.InsertData(
                table: "Frase",
                columns: new[] { "Id", "Autor", "CategoriaId", "Fecha", "Texto" },
                values: new object[] { 174, "Antonio Caso.", 2, new DateTime(2019, 6, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "La idea de las ciencias es reducirse a una sola ciencia, y el ideal de la ciencia única es reducirse a uno sola proposición." });

            migrationBuilder.InsertData(
                table: "Frase",
                columns: new[] { "Id", "Autor", "CategoriaId", "Fecha", "Texto" },
                values: new object[] { 173, "Miguel de Cervantes Saavedra.", 2, new DateTime(2019, 6, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ninguna ciencia, en cuanto a ciencia, engaña; el engaño está en quien lo sabe." });

            migrationBuilder.InsertData(
                table: "Frase",
                columns: new[] { "Id", "Autor", "CategoriaId", "Fecha", "Texto" },
                values: new object[] { 172, "Albert Szent.", 2, new DateTime(2019, 6, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "Investigar es ver lo que todo el mundo ha visto, y pensar lo que nadie más ha pensado." });

            migrationBuilder.InsertData(
                table: "Frase",
                columns: new[] { "Id", "Autor", "CategoriaId", "Fecha", "Texto" },
                values: new object[] { 171, "Edward Teller.", 2, new DateTime(2019, 6, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "La ciencia de hoy en día es la tecnología del mañana." });

            migrationBuilder.InsertData(
                table: "Frase",
                columns: new[] { "Id", "Autor", "CategoriaId", "Fecha", "Texto" },
                values: new object[] { 170, "Thomas Henry Huxley.", 2, new DateTime(2019, 6, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "La ciencia comete suicidio cuando adopta un credo." });

            migrationBuilder.InsertData(
                table: "Frase",
                columns: new[] { "Id", "Autor", "CategoriaId", "Fecha", "Texto" },
                values: new object[] { 169, "William James Durante.", 2, new DateTime(2019, 6, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Toda ciencia comienza como filosofía y acaba como arte." });

            migrationBuilder.InsertData(
                table: "Frase",
                columns: new[] { "Id", "Autor", "CategoriaId", "Fecha", "Texto" },
                values: new object[] { 168, "Gastón Bachelard.", 2, new DateTime(2019, 6, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "La ciencia es la estética de la inteligencia." });

            migrationBuilder.InsertData(
                table: "Frase",
                columns: new[] { "Id", "Autor", "CategoriaId", "Fecha", "Texto" },
                values: new object[] { 167, "William Osler.", 2, new DateTime(2019, 6, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "En la ciencia el reconocimiento se concede al hombre que convence al mundo, no a aquel a quien se le ocurre la idea." });

            migrationBuilder.InsertData(
                table: "Frase",
                columns: new[] { "Id", "Autor", "CategoriaId", "Fecha", "Texto" },
                values: new object[] { 176, "Max Planck.", 2, new DateTime(2019, 6, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Una nueva verdad científica no triunfa convenciendo a sus oponentes y haciéndoles ver la luz, sino más bien porque sus adversarios finalmente mueren, y una nueva generación crece familiarizándose con esa luz." });

            migrationBuilder.InsertData(
                table: "Frase",
                columns: new[] { "Id", "Autor", "CategoriaId", "Fecha", "Texto" },
                values: new object[] { 142, "Ralph Waldo Emerson.", 2, new DateTime(2019, 5, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "La ciencia no conoce su deuda a la imaginación." });

            migrationBuilder.InsertData(
                table: "Frase",
                columns: new[] { "Id", "Autor", "CategoriaId", "Fecha", "Texto" },
                values: new object[] { 141, "Albert Einstein.", 2, new DateTime(2019, 5, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "Lo más incomprensible acerca de este mundo es que es comprensible." });

            migrationBuilder.InsertData(
                table: "Frase",
                columns: new[] { "Id", "Autor", "CategoriaId", "Fecha", "Texto" },
                values: new object[] { 140, "Paul Valéry.", 2, new DateTime(2019, 5, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Debemos llamar ciencia sólo al conjunto de las fórmulas que triunfan siempre. Todo el resto es literatura." });

            migrationBuilder.InsertData(
                table: "Frase",
                columns: new[] { "Id", "Autor", "CategoriaId", "Fecha", "Texto" },
                values: new object[] { 115, "Isaac Asimov.", 2, new DateTime(2019, 4, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "El aspecto más triste de la vida en este momento es que la ciencia reúne el conocimiento más rápidamente que la sociedad reúne la sabiduría." });

            migrationBuilder.InsertData(
                table: "Frase",
                columns: new[] { "Id", "Autor", "CategoriaId", "Fecha", "Texto" },
                values: new object[] { 114, "Max Planck.", 2, new DateTime(2019, 4, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "La ciencia es la progresiva aproximación del hombre al mundo real." });

            migrationBuilder.InsertData(
                table: "Frase",
                columns: new[] { "Id", "Autor", "CategoriaId", "Fecha", "Texto" },
                values: new object[] { 113, "Galileo Galilei.", 2, new DateTime(2019, 4, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "En lo tocante a la ciencia, la autoridad de un millar no es superior al humilde razonamiento de una sola persona." });

            migrationBuilder.InsertData(
                table: "Frase",
                columns: new[] { "Id", "Autor", "CategoriaId", "Fecha", "Texto" },
                values: new object[] { 112, "Karl Raiumd Popper.", 2, new DateTime(2019, 4, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "La ciencia será siempre una búsqueda, jamás un descubrimiento real. Es un viaje, nunca una llegada." });

            migrationBuilder.InsertData(
                table: "Frase",
                columns: new[] { "Id", "Autor", "CategoriaId", "Fecha", "Texto" },
                values: new object[] { 111, "Aristóteles.", 2, new DateTime(2019, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "El fin de la ciencia especulativa es la verdad, y el fin de la ciencia práctica es la acción" });

            migrationBuilder.InsertData(
                table: "Frase",
                columns: new[] { "Id", "Autor", "CategoriaId", "Fecha", "Texto" },
                values: new object[] { 110, "Jared Diamond.", 1, new DateTime(2019, 4, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "La tecnología causa problemas, al ritmo que los resuelve." });

            migrationBuilder.InsertData(
                table: "Frase",
                columns: new[] { "Id", "Autor", "CategoriaId", "Fecha", "Texto" },
                values: new object[] { 109, "Kim J. Vicente.", 1, new DateTime(2019, 4, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "La tecnología con todas sus promesas y su potencial, se ha ido del control del hombre, tanto que amenaza contra la humanidad." });

            migrationBuilder.InsertData(
                table: "Frase",
                columns: new[] { "Id", "Autor", "CategoriaId", "Fecha", "Texto" },
                values: new object[] { 108, "Eliezer Yudkowsky.", 1, new DateTime(2019, 4, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "El mayor daño que puede hacer la inteligencia artificial es que la gente crea que la puede comprender." });

            migrationBuilder.InsertData(
                table: "Frase",
                columns: new[] { "Id", "Autor", "CategoriaId", "Fecha", "Texto" },
                values: new object[] { 107, "Marshall McLuhan.", 1, new DateTime(2019, 4, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Primero creamos las herramientas, luego las herramientas nos crean." });

            migrationBuilder.InsertData(
                table: "Frase",
                columns: new[] { "Id", "Autor", "CategoriaId", "Fecha", "Texto" },
                values: new object[] { 116, "Albert Einstein.", 2, new DateTime(2019, 4, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "La ciencia sin religión es coja, la religión sin ciencia es ciega." });

            migrationBuilder.InsertData(
                table: "Frase",
                columns: new[] { "Id", "Autor", "CategoriaId", "Fecha", "Texto" },
                values: new object[] { 106, "Suzy Kassem.", 1, new DateTime(2019, 4, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "El lenguaje sigue separándonos, aun cuando la tecnología sigue intentando unirnos." });

            migrationBuilder.InsertData(
                table: "Frase",
                columns: new[] { "Id", "Autor", "CategoriaId", "Fecha", "Texto" },
                values: new object[] { 104, "Nick Joaquin.", 1, new DateTime(2019, 4, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "La cosa no es como se usa la herramienta, sino cómo ella nos usa." });

            migrationBuilder.InsertData(
                table: "Frase",
                columns: new[] { "Id", "Autor", "CategoriaId", "Fecha", "Texto" },
                values: new object[] { 103, "John Pfeiffer.", 1, new DateTime(2019, 4, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "El hombre es un pensador lento, sentimental, pero brillante. Las máquinas son rápidas, precisas y estúpidas." });

            migrationBuilder.InsertData(
                table: "Frase",
                columns: new[] { "Id", "Autor", "CategoriaId", "Fecha", "Texto" },
                values: new object[] { 102, "Tiffany Madison.", 1, new DateTime(2019, 4, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "No podemos controlar lo que crece en internet, pero tampoco tenemos que mirarlo." });

            migrationBuilder.InsertData(
                table: "Frase",
                columns: new[] { "Id", "Autor", "CategoriaId", "Fecha", "Texto" },
                values: new object[] { 101, "Billy Cox.", 1, new DateTime(2019, 4, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "La tecnología debería mejorar tu vida, no volverse tu vida." });

            migrationBuilder.InsertData(
                table: "Frase",
                columns: new[] { "Id", "Autor", "CategoriaId", "Fecha", "Texto" },
                values: new object[] { 100, "Godfrey Reggio.", 1, new DateTime(2019, 4, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "No es que usemos la tecnología, vivimos con la tecnología." });

            migrationBuilder.InsertData(
                table: "Frase",
                columns: new[] { "Id", "Autor", "CategoriaId", "Fecha", "Texto" },
                values: new object[] { 99, "", 1, new DateTime(2019, 4, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "La tecnología le sirve al progreso, nunca lo controla." });

            migrationBuilder.InsertData(
                table: "Frase",
                columns: new[] { "Id", "Autor", "CategoriaId", "Fecha", "Texto" },
                values: new object[] { 98, "Steve Jobs.", 1, new DateTime(2019, 4, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vamos, hay que crear el mañana, y no preocuparse por el ayer." });

            migrationBuilder.InsertData(
                table: "Frase",
                columns: new[] { "Id", "Autor", "CategoriaId", "Fecha", "Texto" },
                values: new object[] { 97, "Tim O’Reilly.", 1, new DateTime(2019, 4, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Una de las cosas que hace la tecnología es crear nuevas oportunidades para trabajos deseados." });

            migrationBuilder.InsertData(
                table: "Frase",
                columns: new[] { "Id", "Autor", "CategoriaId", "Fecha", "Texto" },
                values: new object[] { 96, "Thomas Edison.", 1, new DateTime(2019, 4, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "No, no fallé. Sólo encontré diez mil formas que no funcionarán." });

            migrationBuilder.InsertData(
                table: "Frase",
                columns: new[] { "Id", "Autor", "CategoriaId", "Fecha", "Texto" },
                values: new object[] { 105, "Richard Kadrey.", 1, new DateTime(2019, 4, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Cada vez que llega una nueva tecnología, tiene que estar acompañada de demandas por nuevas habilidades, nuevos idiomas." });

            migrationBuilder.InsertData(
                table: "Frase",
                columns: new[] { "Id", "Autor", "CategoriaId", "Fecha", "Texto" },
                values: new object[] { 375, "Erwin Heisenberg.", 3, new DateTime(2020, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Me había imaginado aplicando física nuclear y la teoría de los rayos cósmicos en mayor escala en los tiempos de paz. Practicar la física moderna de una pequeña escala no sirve para nada. " });

            migrationBuilder.InsertData(
                table: "Frase",
                columns: new[] { "Id", "Autor", "CategoriaId", "Fecha", "Texto" },
                values: new object[] { 117, "Thomas Huxley.", 2, new DateTime(2019, 4, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "La ciencia es simplemente sentido común en su mejor momento." });

            migrationBuilder.InsertData(
                table: "Frase",
                columns: new[] { "Id", "Autor", "CategoriaId", "Fecha", "Texto" },
                values: new object[] { 119, "Ruy Perez Tamayo.", 2, new DateTime(2019, 4, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "La ciencia tiene una característica maravillosa, y es que aprende de sus errores." });

            migrationBuilder.InsertData(
                table: "Frase",
                columns: new[] { "Id", "Autor", "CategoriaId", "Fecha", "Texto" },
                values: new object[] { 139, "Albert Einstein.", 2, new DateTime(2019, 5, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "La mayoría de la gente dice que el intelecto es lo que hace a un gran científico. Están equivocados: es el carácter." });

            migrationBuilder.InsertData(
                table: "Frase",
                columns: new[] { "Id", "Autor", "CategoriaId", "Fecha", "Texto" },
                values: new object[] { 138, "Louis Pasteur.", 2, new DateTime(2019, 5, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "La ciencia es el alma de la prosperidad de las naciones y la fuente de vida de todo progreso." });

            migrationBuilder.InsertData(
                table: "Frase",
                columns: new[] { "Id", "Autor", "CategoriaId", "Fecha", "Texto" },
                values: new object[] { 137, "Thomas Huxley.", 2, new DateTime(2019, 5, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "La ciencia no es más que sentido común amaestrado y organizado." });

            migrationBuilder.InsertData(
                table: "Frase",
                columns: new[] { "Id", "Autor", "CategoriaId", "Fecha", "Texto" },
                values: new object[] { 136, "Unamuno.", 2, new DateTime(2019, 5, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "La ciencia es un cementerio de ideas muertas, aunque de ellas puede salir la vida." });

            migrationBuilder.InsertData(
                table: "Frase",
                columns: new[] { "Id", "Autor", "CategoriaId", "Fecha", "Texto" },
                values: new object[] { 135, "Leonardo da Vinci.", 2, new DateTime(2019, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Son vanas y están plagadas de errores las ciencias que no han nacido del experimento, madre de toda incertidumbre." });

            migrationBuilder.InsertData(
                table: "Frase",
                columns: new[] { "Id", "Autor", "CategoriaId", "Fecha", "Texto" },
                values: new object[] { 134, "Stephen Hawking.", 2, new DateTime(2019, 5, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "La ciencia no es solo una disciplina de razón, sino también de romance y pasión." });

            migrationBuilder.InsertData(
                table: "Frase",
                columns: new[] { "Id", "Autor", "CategoriaId", "Fecha", "Texto" },
                values: new object[] { 133, "Galileo Galilei.", 2, new DateTime(2019, 5, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Renegando los principios básicos de la ciencia uno puede sostener cualquier paradoja." });

            migrationBuilder.InsertData(
                table: "Frase",
                columns: new[] { "Id", "Autor", "CategoriaId", "Fecha", "Texto" },
                values: new object[] { 132, "Nikola Tesla.", 2, new DateTime(2019, 5, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "La historia de la ciencia nos demuestra que toda teoría es perecedera. Con cada verdad que nos es revelada ganamos un mejor entendimiento de la naturaleza, y nuestras concepciones y vicisitudes cambian por completo." });

            migrationBuilder.InsertData(
                table: "Frase",
                columns: new[] { "Id", "Autor", "CategoriaId", "Fecha", "Texto" },
                values: new object[] { 131, "Hipócrates.", 2, new DateTime(2019, 5, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hay dos cosas: ciencia y la opinión. El primero engendra conocimiento, el último ignorancia." });

            migrationBuilder.InsertData(
                table: "Frase",
                columns: new[] { "Id", "Autor", "CategoriaId", "Fecha", "Texto" },
                values: new object[] { 118, "Leonardo da Vinci.", 2, new DateTime(2019, 4, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "La ciencia más útil es aquella cuyo fruto es el más comunicable." });

            migrationBuilder.InsertData(
                table: "Frase",
                columns: new[] { "Id", "Autor", "CategoriaId", "Fecha", "Texto" },
                values: new object[] { 130, "Ivan Pavlov.", 2, new DateTime(2019, 5, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Los hechos son el aire de la ciencia. Sin ellos, un hombre de ciencia nunca podrá elevarse." });

            migrationBuilder.InsertData(
                table: "Frase",
                columns: new[] { "Id", "Autor", "CategoriaId", "Fecha", "Texto" },
                values: new object[] { 128, "Marie Curie.", 2, new DateTime(2019, 5, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Soy de las que piensan que la ciencia tiene una gran belleza. Un científico en su laboratorio no es sólo un técnico: también es un niño colocado ante fenómenos naturales que lo impresionan como un cuento de hadas." });

            migrationBuilder.InsertData(
                table: "Frase",
                columns: new[] { "Id", "Autor", "CategoriaId", "Fecha", "Texto" },
                values: new object[] { 127, "Herbert Spencer.", 2, new DateTime(2019, 5, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "La ciencia aumenta nuestro poder en la medida en que reduce nuestra soberbia." });

            migrationBuilder.InsertData(
                table: "Frase",
                columns: new[] { "Id", "Autor", "CategoriaId", "Fecha", "Texto" },
                values: new object[] { 126, "Louis Pasteur.", 2, new DateTime(2019, 5, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "Las ciencias aplicadas no existen, sólo las aplicaciones de la ciencia." });

            migrationBuilder.InsertData(
                table: "Frase",
                columns: new[] { "Id", "Autor", "CategoriaId", "Fecha", "Texto" },
                values: new object[] { 125, "Francois Rabelais.", 2, new DateTime(2019, 5, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ciencia sin conciencia no es más que ruina del alma." });

            migrationBuilder.InsertData(
                table: "Frase",
                columns: new[] { "Id", "Autor", "CategoriaId", "Fecha", "Texto" },
                values: new object[] { 124, "Albert Einstein.", 2, new DateTime(2019, 5, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "La mayoría de las ideas fundamentales de la ciencia son esencialmente sencillas, y por regla general pueden ser expresadas en un lenguaje comprensible para todos." });

            migrationBuilder.InsertData(
                table: "Frase",
                columns: new[] { "Id", "Autor", "CategoriaId", "Fecha", "Texto" },
                values: new object[] { 123, "Karl Schlecta.", 2, new DateTime(2019, 5, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Los científicos no persiguen la verdad; es ésta la que los persigue a ellos." });

            migrationBuilder.InsertData(
                table: "Frase",
                columns: new[] { "Id", "Autor", "CategoriaId", "Fecha", "Texto" },
                values: new object[] { 122, "Giovanni Papini.", 2, new DateTime(2019, 5, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "En todos los grandes hombres de la ciencia existe el soplo de la fantasía." });

            migrationBuilder.InsertData(
                table: "Frase",
                columns: new[] { "Id", "Autor", "CategoriaId", "Fecha", "Texto" },
                values: new object[] { 121, "Henri Poincaré.", 2, new DateTime(2019, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "La ciencia está hecha de datos, como una casa de piedras. Pero un montón de datos no es ciencia más de lo que un montón de piedras es una casa." });

            migrationBuilder.InsertData(
                table: "Frase",
                columns: new[] { "Id", "Autor", "CategoriaId", "Fecha", "Texto" },
                values: new object[] { 120, "Louis Pasteur.", 2, new DateTime(2019, 4, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "La ciencia no tiene patria." });

            migrationBuilder.InsertData(
                table: "Frase",
                columns: new[] { "Id", "Autor", "CategoriaId", "Fecha", "Texto" },
                values: new object[] { 129, "Neil deGrasse Tyson.", 2, new DateTime(2019, 5, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Lo bueno de la ciencia es que es cierta, creas o no en ella." });

            migrationBuilder.InsertData(
                table: "Frase",
                columns: new[] { "Id", "Autor", "CategoriaId", "Fecha", "Texto" },
                values: new object[] { 376, "Scott Adams.", 3, new DateTime(2020, 1, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Algunos físicos describen la gravedad en términos de diez dimensiones, todas enrolladas. Pero esas no son palabras reales, sino solo referentes, utilizados para referirse a las partes de ecuaciones abstractas. " });

            migrationBuilder.CreateIndex(
                name: "IX_Frase_CategoriaId",
                table: "Frase",
                column: "CategoriaId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Frase");

            migrationBuilder.DropTable(
                name: "Categoria");
        }
    }
}
