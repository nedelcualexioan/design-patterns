using System;
using System.Collections;
using System.Collections.Generic;

namespace design_patterns.Composite
{
    public class SongGroup : SongComponent
    {
        private List<SongComponent> songComponents;

        private String groupName;
        private String groupDescription;

        public String GroupName
        {
            get => groupName;
        }

        public String GroupDescription
        {
            get => groupDescription;
        }

        public SongGroup(String groupName, String groupDescription)
        {
            songComponents = new List<SongComponent>();

            this.groupName = groupName;
            this.groupDescription = groupDescription;
        }

        public void add(SongComponent songComponent)
        {
            songComponents.Add(songComponent);
        }

        public void remove(SongComponent songComponent)
        {
            songComponents.Remove(songComponent);
        }

        public SongComponent GetComponent(int index)
        {
            return songComponents[index];
        }

        public override void displayInfo()
        {
            foreach (SongComponent component in songComponents)
            {
                component.displayInfo();
            }
        }
    }
}