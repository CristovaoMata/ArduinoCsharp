void setup() {
  // Inicializa a comunicação serial a 9600 bps:
  Serial.begin(9600);
  
  // Define o pino 13 como saída:
  pinMode(13, OUTPUT);
}

void loop() {
  // Verifica se há dados disponíveis na porta serial:
  if (Serial.available() > 0) {
    // Lê o byte recebido:
    char received = Serial.read();
    
    // Verifica se o byte recebido é '1' ou '0':
    if (received == '1') {
      // Liga o LED no pino 13:
      digitalWrite(13, HIGH);
      Serial.println("LED ligado");
    } else if (received == '0') {
      // Desliga o LED no pino 13:
      digitalWrite(13, LOW);
      Serial.println("LED desligado");
    }
  }
}

