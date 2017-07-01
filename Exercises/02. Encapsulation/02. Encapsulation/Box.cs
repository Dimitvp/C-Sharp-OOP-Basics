class Box
{
    private double lenght;
    private double widht;
    private double height;

    public Box(double lenght, double width, double height)
    {
        this.lenght = lenght;
        this.widht = width;
        this.height = height;
    }
   
    public double GetSurfaceArea()
    {
       return (2 * this.lenght * this.widht) + ( 2 * this.lenght * this.height ) + ( 2 * this.widht * this.height );
        //2lw + 2lh + 2wh
    }

    public double GetLateralSurfaceArea()
    {
        return ( 2 * this.lenght * this.height ) + ( 2 * this.widht * this.height );
        //2lh + 2wh
    }
    public double GetVolume()
    {
        return this.lenght * this.widht * this.height;
    }

}