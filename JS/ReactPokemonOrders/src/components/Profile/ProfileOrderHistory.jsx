import ProfileOrderHistoryItem from "./ProfileOrderHistoryItem";

const ProfileOrderHistory = ({ orders }) => {
    
    const orderList = orders.map(
        (order, index) => <ProfileOrderHistoryItem key={ index + "-" + order } order={ order }/>
    );

    return (
        <section>
            <h4>Your Pokemon</h4>
            {orderList.length === 0 && <p>You have no Pokemon HAHA</p>}
            <ul>
                { orderList }
            </ul>
        </section> 
    )
}
export default ProfileOrderHistory;  