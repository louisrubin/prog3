using DiasLaborables;

// RUBIN AZAS M. Luis

byte opc;
Console.Write("1- Obtener Dias Calendario\n2- Obtener Dias Laborables\n3- Sumar Dias Laborables\n --> ");
byte.TryParse(Console.ReadLine(), out opc);

if (opc == 1) Calendario.ObtenerDiasCalendario();
else if (opc == 2) Calendario.ObtenerDiasLaborables();
else if (opc == 3) Calendario.SumarDiasLaborables();

