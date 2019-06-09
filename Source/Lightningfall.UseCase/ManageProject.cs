using System;

namespace Lightningfall.UseCase
{
    public class ManageProject : IManageProject
    {
        // ReSharper disable once PrivateFieldCanBeConvertedToLocalVariable
        private readonly IProjectRepository _projectRepository;

        public ManageProject(IProjectRepository projectRepository)
        {
            _projectRepository = projectRepository;
            Project = _projectRepository.Find();
        }

        public IProject Project { get; }
    }
}
