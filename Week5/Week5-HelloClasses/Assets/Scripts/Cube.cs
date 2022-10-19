using System;

public class Cube
{
    private float height;
    private float width;
    private float length;

    public Cube()
    {
        // Default values for my instantiated cube.
        height = 0f;
        width = 0f;
        length = 0f;
    }

    public Cube(float newHeight, float newWidth, float newLength)
    {
        // Should consider testing for positive numbers before accepting the parameters

        height = newHeight;
        width = newWidth;
        length = newLength;
    }

    public float GetVolume()
    {
        return length * width * height;
    }

    public float GetEdgeLength()
    {
        return (4 * length) + (4 * width) + (4 * height);
    }

    public float GetHeight()
    {
        return height;
    }

    public void SetHeight(float newHeight)
    {
        height = newHeight;
    }

    public float GetWidth()
    {
        return width;
    }

    public void SetWidth(float newWidth)
    {
        width = newWidth;
    }

    public float GetLength()
    {
        return length;
    }

    public void SetLength(float newLength)
    {
        length = newLength;
    }
}

