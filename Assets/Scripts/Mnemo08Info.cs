using UnityEngine;
using UnityEngine.UI;

public class Mnemo08Info : MonoBehaviour
{
    [SerializeField] private Text verticalMovementLevel;
    [SerializeField] private Text verticalCoordinate;
    [SerializeField] private Text graspState;
    [SerializeField] private Text graspRotationAngle;
    [SerializeField] private Text destinationPositionOnHorizontalMovement;
    [SerializeField] private Text directControl;
    [SerializeField] private Text movementOnDirectControl;

    private readonly string verticalMovementLevelIsBottom = "Нижний";
    private readonly string verticalMovementLevelIsTop = "Верхний";

    private readonly string verticalCoordinateIs9500 = "9500";
    private readonly string verticalCoordinateIs5000 = "5000";

    private readonly string yesGraspIsClamped = "Да";
    private readonly string noGraspIsNotClamped = "Нет";

    private readonly string graspRotationAngleIs0 = "0";
    private readonly string graspRotationAngleIs = "angle";

    private readonly string destinationPositionIsTvsAssembly = "Сборка ТВС";
    private readonly string destinationPositionIsWashing = "Отмывка";
    private readonly string destinationPositionIsDrying = "Сушка";
    private readonly string destinationPositionIsTightness = "Герметичность";
    private readonly string destinationPositionIsImpurity = "Зарязнённость";
    private readonly string destinationPositionIsWeight = "Масса";
    private readonly string destinationPositionIsGeometry = "Геометрия";
    private readonly string destinationPositionIsBuferStorage = "Буферное хранилище";

    private readonly string directControlIsUsed = "Используется";
    private readonly string directControlIsNotUsed = "Не используется";

    private readonly string movementOnDirectControlIsStop = "Стоп";
    private readonly string movementOnDirectControlIs = "movement";

    public void SetVerticalMovementLevelIsBottom()
    {
        verticalMovementLevel.text = verticalMovementLevelIsBottom;
    }

    public void SetVerticalMovementLevelIsTop()
    {
        verticalMovementLevel.text = verticalMovementLevelIsTop;
    }

    public void SetVerticalCoordinateIs5000()
    {
        verticalCoordinate.text = verticalCoordinateIs5000;
    }

    public void SetVerticalCoordinateIs9500()
    {
        verticalCoordinate.text = verticalCoordinateIs9500;
    }

    public void SetGraspIsClamped()
    {
        graspState.text = yesGraspIsClamped;
    }

    public void SetGraspIsNotClamped()
    {
        graspState.text = noGraspIsNotClamped;
    }

    public void SetGraspRotationAngleIs0()
    {
        graspRotationAngle.text = graspRotationAngleIs0;
    }

    public void SetGraspRotationAngleIs()
    {
        graspRotationAngle.text = graspRotationAngleIs;
    }

    public void SetDestinationPositionIsWashing()
    {
        destinationPositionOnHorizontalMovement.text = destinationPositionIsWashing;
    }

    public void SetDestinationPositionIsDrying()
    {
        destinationPositionOnHorizontalMovement.text = destinationPositionIsDrying;
    }

    public void SetDestinationPositionIsTightness()
    {
        destinationPositionOnHorizontalMovement.text = destinationPositionIsTightness;
    }

    public void SetDestinationPositionIsImpurity()
    {
        destinationPositionOnHorizontalMovement.text = destinationPositionIsImpurity;
    }

    public void SetDestinationPositionIsWeight()
    {
        destinationPositionOnHorizontalMovement.text = destinationPositionIsWeight;
    }

    public void SetDestinationPositionIsGeometry()
    {
        destinationPositionOnHorizontalMovement.text = destinationPositionIsGeometry;
    }

    public void SetDestinationPositionIsBuferStorage()
    {
        destinationPositionOnHorizontalMovement.text = destinationPositionIsBuferStorage;
    }

    public void SetDirectControlIsUsed()
    {
        directControl.text = directControlIsUsed;
    }

    public void SetDirectControlIsNotUsed()
    {
        directControl.text = directControlIsNotUsed;
    }

    public void SetMovementOnDirectControlIsStop()
    {
        movementOnDirectControl.text = movementOnDirectControlIsStop;
    }

    public void SetMovementOnDirectControlIs()
    {
        movementOnDirectControl.text = movementOnDirectControlIs;
    }

    // Start is called before the first frame update
    void Start()
    {
        verticalMovementLevel.text = verticalMovementLevelIsTop;
        verticalCoordinate.text = verticalCoordinateIs9500;
        graspState.text = noGraspIsNotClamped;
        graspRotationAngle.text = graspRotationAngleIs0;
        destinationPositionOnHorizontalMovement.text = destinationPositionIsTvsAssembly;
        directControl.text = directControlIsNotUsed;
        movementOnDirectControl.text = movementOnDirectControlIsStop;
    }
}
