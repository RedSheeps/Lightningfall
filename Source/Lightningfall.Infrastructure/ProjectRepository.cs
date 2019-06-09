using System;
using System.Collections.Generic;
using System.Linq;

namespace Lightningfall.Infrastructure
{
    public class ProjectRepository : IProjectRepository
    {
        private static readonly IProject _project;

        static ProjectRepository()
        {
            _project = new Project("");
            _project.AddTask(new Task("業務分析"){IsManagedSchedule = true});
            _project.AddTask(new Task("ドメイン分析") { IsManagedSchedule = true });
            _project.AddTask(new Task("アーキテクチャ設計") { IsManagedSchedule = true });
            _project.AddTask(new Task("プロダクト バックログ") { IsManagedSchedule = true });
            _project.AddTask(new Task("スプリント ダッシュボード") { IsManagedSchedule = true });
            _project.AddTask(new Task("プロジェクト スケジュール") { IsManagedSchedule = true });
            _project.AddTask(new Task("プロジェクト カレンダー") { IsManagedSchedule = true });
            _project.AddTask(new Task("プロジェクト リソース") { IsManagedSchedule = true });

            var task = _project.Tasks.First();
            task.AddTask(new Task("ブレスト") { EstimatedManHour = 4, IsManagedSchedule = true});
            task.AddTask(new Task("業務モデル作成") { EstimatedManHour = 4, IsManagedSchedule = true});
            task.Tasks[1].AddTask(new Task("作成") { EstimatedManHour = 4 });
            task.Tasks[1].AddTask(new Task("社内レビュー") { EstimatedManHour = 4 });
            task.Tasks[1].AddTask(new Task("社内レビューバック") { EstimatedManHour = 4 });
            task.Tasks[1].AddTask(new Task("社外レビュー") { EstimatedManHour = 4 });
            task.Tasks[1].AddTask(new Task("社外レビューバック") { EstimatedManHour = 4 });
        }

        public IProject Find() => _project;
    }
}
