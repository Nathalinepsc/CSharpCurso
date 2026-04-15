DateTimeExample();

static void DateTimeExample()
{
  DateTime dataInicio = new DateTime(2025, 10, 01, 14, 25, 32);
  Console.WriteLine($"Data de inicio: {dataInicio.ToString("dd/MM/yyyy HH:mm:ss")}");
  DateTime dataFim = dataInicio.AddDays(260);
  Console.WriteLine($"Data de fim: {dataFim.ToString("dd/MM/yyyy HH:mm:ss")}");

  DateTime hoje = DateTime.Today;
  Console.WriteLine($"Data de hoje: {hoje}");
  DateTime agora = DateTime.Now;
  Console.WriteLine($"Data e hora atual: {agora}");
  DayOfWeek diaSemana = hoje.DayOfWeek;
  Console.WriteLine($"Dia da semana: {diaSemana}");
  DateTime dataFutura = hoje.AddDays(10);
  Console.WriteLine($"Data futura (10 dias a partir de hoje): {dataFutura.ToString("dd/MM/yyyy")}");
  bool ehorariodeverao = agora.IsDaylightSavingTime();
  Console.WriteLine($"Estamos no horário de verão? {ehorariodeverao}");

  DateOnly dateOnly = new DateOnly(2025, 10, 01);
  Console.WriteLine($"Data: {dateOnly}");
  DateOnly dateOnlyFromDateNow = DateOnly.FromDateTime(DateTime.Now);
  Console.WriteLine($"Data atual: {dateOnlyFromDateNow}");

  DateTime horaEntrada = DateTime.Now;
  Console.WriteLine($"Hora de entrada: {horaEntrada}");
  TimeSpan HorarioTrabalho = new TimeSpan(8, 0, 0);
  DateTime horaSaida = horaEntrada.Add(HorarioTrabalho);
  Console.WriteLine($"Hora de saída: {horaSaida}");
  DateTime horaAlmoco = horaEntrada.AddHours(4);
  Console.WriteLine($"Hora do almoço: {horaAlmoco}");
  DateTime horaAlmocoFim = horaAlmoco.AddHours(1);
  Console.WriteLine($"Fim do horário de almoço: {horaAlmocoFim}");
}

