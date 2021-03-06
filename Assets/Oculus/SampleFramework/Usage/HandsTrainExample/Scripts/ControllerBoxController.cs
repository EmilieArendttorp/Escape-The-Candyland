/************************************************************************************

Copyright (c) Facebook Technologies, LLC and its affiliates. All rights reserved.  

See SampleFramework license.txt for license terms.  Unless required by applicable law 
or agreed to in writing, the sample code is provided “AS IS” WITHOUT WARRANTIES OR 
CONDITIONS OF ANY KIND, either express or implied.  See the license for specific 
language governing permissions and limitations under the license.

************************************************************************************/

using UnityEngine;
using UnityEngine.Assertions;

namespace OculusSampleFramework
{
	public class ControllerBoxController : MonoBehaviour
	{
		[SerializeField] PuzzleButton puzzleButton1= null;
		[SerializeField] PuzzleButton puzzleButton2 = null;
		[SerializeField] PuzzleButton puzzleButton3 = null;
		[SerializeField] PuzzleButton puzzleButton4 = null;

		int correctCounter = 0;

		ButtonPuzzleManager buttonPuzzleManager = null;
		GesturePuzzleManager gesturePuzzleManager = null;

		private void Awake()
		{
			buttonPuzzleManager = FindObjectOfType<ButtonPuzzleManager>();
			gesturePuzzleManager = FindObjectOfType<GesturePuzzleManager>();
		}

        public void Button1(InteractableStateArgs obj)
		{
			if (obj.NewInteractableState == InteractableState.ActionState)
			{
				if(puzzleButton1.isAnswer == true)
                {
					correctCounter++;
					Debug.Log("is Answer" + correctCounter);
					buttonPuzzleManager.PickPuzzleCase();

					if (correctCounter == 3)
					{
						OnPuzzleCompletion();

					}
				}
				else
                {
					Debug.Log("Not Answer");
					correctCounter = 0;
					buttonPuzzleManager.PickPuzzleCase();
				}
				
			}
		}

		public void Button2(InteractableStateArgs obj)
		{
			if (obj.NewInteractableState == InteractableState.ActionState)
			{
				if (puzzleButton2.isAnswer == true)
				{					
					correctCounter++;
					Debug.Log("is Answer" + correctCounter);
					buttonPuzzleManager.PickPuzzleCase();

					if (correctCounter == 3)
					{
						OnPuzzleCompletion();

					}
				}
				else
				{
					Debug.Log("Not Answer");
					correctCounter = 0;
					buttonPuzzleManager.PickPuzzleCase();
				}
			}
		}

		public void Button3(InteractableStateArgs obj)
		{
			if (obj.NewInteractableState == InteractableState.ActionState)
			{
				if (puzzleButton3.isAnswer == true)
				{					
					correctCounter++;
					Debug.Log("is Answer" + correctCounter);
					buttonPuzzleManager.PickPuzzleCase();

					if (correctCounter == 3)
					{
						OnPuzzleCompletion();

					}
				}
				else
				{
					Debug.Log("Not Answer");
					correctCounter = 0;
					buttonPuzzleManager.PickPuzzleCase();
				}
			}
		}

		public void Button4(InteractableStateArgs obj)
		{
			if (obj.NewInteractableState == InteractableState.ActionState)
			{
				if (puzzleButton4.isAnswer == true)
				{
					correctCounter++;
					Debug.Log("is Answer" + correctCounter);
					buttonPuzzleManager.PickPuzzleCase();

					if (correctCounter == 3)
					{
						OnPuzzleCompletion();

					}
				}
				else
				{
					Debug.Log("Not Answer");
					correctCounter = 0;
					buttonPuzzleManager.PickPuzzleCase();
				}
			}
		}

        public void OnPuzzleCompletion()
        {
			transform.root.gameObject.SetActive(false);
			gesturePuzzleManager.ColoredButtonsCompletion();
		}
    }
}
