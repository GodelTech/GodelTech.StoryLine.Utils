using System;

namespace GodelTech.StoryLine.Utils.Contracts
{
    public interface IDataConverter
    {
        object Convert(object data, Type type);
    }
}