using Microsoft.AspNetCore.Components;

namespace BlazorQuiz.Components
{
    public class AnswersBase : ComponentBase
    {
        [Parameter]
        public string Answer { get; set; } = string.Empty;

        [Parameter]
        public EventCallback<string> OnSelected { get; set; }

        public async Task SelectAnswer()
        {
            await OnSelected.InvokeAsync(Answer);
        }
    }
}
