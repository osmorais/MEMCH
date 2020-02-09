import pigpio

class SensorFluxo:

    def __init__(self):
        self.flowGpio = 18
        self.pulsos = 0
        self.pi = pigpio.pi()
        self.pi.set_mode(self.flowGpio, pigpio.INPUT)
        self.pi.set_pull_up_down(self.flowGpio, pigpio.PUD_DOWN)
        self.flowCallback = self.pi.callback(self.flowGpio, pigpio.FALLING_EDGE)

    def registrar(self):
        self.pulsos = self.flowCallback.tally()

        # 450 pulsos por litro
        #print("Pulsos:", self.pulsos, "- Mililitros:", round((self.pulsos * 2.222222222222223), 3)
        #      , "- Metros Cubicos:", round(((self.pulsos * 2.222222222222223) / 1000000), 3))

        return self.pulsos * 2.222222222222223
        #pi.stop()