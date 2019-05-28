using Castle.Core;
using Castle.MicroKernel;
using Castle.MicroKernel.ModelBuilder;

namespace Project
{
    public class TransientEqualizer : IContributeComponentModelConstruction
    {
        public void ProcessModel(IKernel kernel, ComponentModel model)
        {
            if (model.LifestyleType == LifestyleType.PerWebRequest)
            {
                model.LifestyleType = LifestyleType.Scoped;
            }
        }
    }
}
