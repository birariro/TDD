# TDD
: C# 과 JAVA 를 기준으로 TDD 를 작성한다.


## C-Shap
### Assert 사용 방법
#### Assert.IsTrue(value) : value 가 True 인지 테스트한다. 
#### Assert.IsFalse(value) : value 가 False 인지 테스트한다. 
#### Assert.AreEqual(expected, value) : 예상값 expected 과 실제 값 value 가 같은지 테스트한다.
#### Assert.IsNull(value) : vlaue 가 null 인지 테스트한다.
#### Assert.Assert.IsNotNull(value) : vlaue 가 null 이 아닌지 테스트한다.

위의 메소드들은 매개변수 2개를 사용할수있다. 1번 매개변수는 위와같고 2번 매개변수는 실패했을때 보여줄 메시지를 보여준다.
####  Assert.IsNull(value,"value가 null이 아니다.") : vlaue가 null인지 테스트하고 만약 테스트 실패라면 메시지를 보여준다.
