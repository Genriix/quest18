namespace quest18._2
{
    class Operations
    {
        public float Add(float a, float b) { return a + b; }
        public float Sub(float a, float b) { return a - b; }
        public float Mul(float a, float b) { return a * b; }
        public float Div(float a, float b) { if (b == 0) { return 0; } else { return a / b; } }
    }
}