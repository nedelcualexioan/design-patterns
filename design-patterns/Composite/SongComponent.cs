using System;

namespace design_patterns.Composite
{
    public abstract class SongComponent
    {
        public void add(SongComponent songComponent)
        {

        }

        public void remove(SongComponent songComponent)
        {

        }

        public SongComponent GetComponent(int index)
        {
            return null;
        }

        public abstract void displayInfo();

    }
}