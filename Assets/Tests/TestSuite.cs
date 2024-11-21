using System.Collections;
using UnityEngine;
using UnityEngine.TestTools;
using NUnit.Framework;

public class TestSuite{
    private Game game;

    [SetUp] public void Setup(){
        GameObject gameGameObject = Object.Instantiate(Resources.Load<GameObject>("Prefabs/Game"));
        game = gameGameObject.GetComponent<Game>();
    }

    [TearDown] public void TearDown(){
        Object.Destroy(game.gameObject);
    }

    [UnityTest] public IEnumerator CollectCoinIncrementsValue(){
        yield return new WaitForSeconds(5f);
        Assert.True(game.GetGameManager().CoinCount != 0);
    }

    [UnityTest] public IEnumerator JumpingWorks(){
        float initialPos = game.GetPlayer().transform.position.y;
        game.GetPlayer().Jump(game.GetPlayer().jumpForce);
        yield return new WaitForSeconds(0.5f);
        float finalPos = game.GetPlayer().transform.position.y;
        Assert.True(initialPos < finalPos);
    }

    [UnityTest] public IEnumerator PlayerPushesTheIce(){
        game.GetCollisionTester().ObjectTag = "IceCube";
        yield return new WaitForSeconds(5f);
        Assert.True(game.GetCollisionTester().ObjectCollided);
    }

    [UnityTest] public IEnumerator StandingHere(){
        game.GetCollisionTester().ObjectTag = "Ground";
        yield return new WaitForSeconds(5f);
        Assert.True(game.GetCollisionTester().ObjectStayed);
    }
}