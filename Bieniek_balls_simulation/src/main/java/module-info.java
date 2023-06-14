module com.example.bieniek_balls_simulation {
    requires javafx.controls;
    requires javafx.fxml;


    opens com.example.bieniek_balls_simulation to javafx.fxml;
    exports com.example.bieniek_balls_simulation;
}