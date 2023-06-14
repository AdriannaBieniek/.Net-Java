package com.example.bieniek_balls_simulation;

import javafx.animation.Animation;
import javafx.animation.KeyFrame;
import javafx.animation.Timeline;
import javafx.event.ActionEvent;
import javafx.event.EventHandler;
import javafx.scene.Scene;
import javafx.scene.layout.Pane;
import javafx.scene.paint.Color;
import javafx.scene.shape.Circle;
import javafx.stage.Stage;
import javafx.util.Duration;

public class Drawing {
    public void start(Stage primaryStage,int x, int y,int radius, int screen_height,int screen_width,double speed){


        Circle circle = new Circle ();
        circle.setCenterX(x);
        circle.setCenterY(y );
        circle.setRadius(radius);
        circle.setStroke(Color.RED);
        circle.setFill(Color.RED);

        Circle circle2 = new Circle ();
        circle2.setCenterX(x+100);
        circle2.setCenterY(y+100);
        circle2.setRadius(radius);
        circle2.setStroke(Color.GREEN);
        circle2.setFill(Color.GREEN);

        Pane pane = new Pane();
        pane.getChildren().add(circle);
        pane.getChildren().add(circle2);

        Scene scene = new Scene (pane,screen_height,screen_width);
        primaryStage.setTitle("Balls simulation!");
        primaryStage.setScene(scene);

        Timeline timeline = new Timeline(new KeyFrame(Duration.millis(20), new EventHandler<ActionEvent>() {
            double deltaX = speed;
            double deltaY =3* speed;
            double deltaX2 = 2*speed;
            double deltaY2 = speed;

        public void handle(ActionEvent actionEvent) {


            circle.setCenterX(circle.getCenterX() + deltaX);
            circle.setCenterY(circle.getCenterY() + deltaY);

            boolean rightBorder = circle.getCenterX() >= (pane.getWidth() - circle.getRadius());
            boolean leftBorder = circle.getCenterX() <= (circle.getRadius());
            boolean bottomBorder = circle.getCenterY() >= (pane.getHeight() - circle.getRadius());
            boolean topBorder = circle.getCenterY() <= (circle.getRadius());


            circle2.setCenterX(circle2.getCenterX() + deltaX2);
            circle2.setCenterY(circle2.getCenterY() + deltaY2);

            boolean rightBorder2 = circle2.getCenterX() >= (pane.getWidth() - circle2.getRadius());
            boolean leftBorder2 = circle2.getCenterX() <= (circle2.getRadius());
            boolean bottomBorder2 = circle2.getCenterY() >= (pane.getHeight() - circle2.getRadius());
            boolean topBorder2 = circle2.getCenterY() <= (circle2.getRadius());

            boolean circleCollision = circle.getBoundsInLocal().intersects(circle2.getBoundsInLocal());

            if (rightBorder || leftBorder) {
//                deltaX = (Math.signum(deltaX) * (Math.floor(Math.random() * 3) + 2));
                deltaX *= -1;
            }
            if (bottomBorder || topBorder) {
//                deltaY = (Math.signum(deltaY) * (Math.floor(Math.random() * 3) + 2));
                deltaY *= -1;
            }

            if (rightBorder2 || leftBorder2) {
//                deltaX2 = (Math.signum(deltaX2) * (Math.floor(Math.random() * 3) + 2));
                deltaX2 *= -1;
            }
            if (bottomBorder2 || topBorder2) {
//                deltaY2 = (Math.signum(deltaY2) * (Math.floor(Math.random() * 3) + 2));
                deltaY2 *= -1;

            }
            if (circleCollision)
            {
                deltaX *= -1;
                deltaY *= -1;
                deltaX2 *= -1;
                deltaY2 *= -1;
            }
        }
        }));

        timeline.setCycleCount(Animation.INDEFINITE);
        timeline.setAutoReverse(false);
        timeline.play();

        primaryStage.show();
    }

}
