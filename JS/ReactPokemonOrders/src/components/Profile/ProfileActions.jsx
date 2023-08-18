import { Link } from "react-router-dom";
import { storageDelete, storageSave } from "../../utils/storage";
import { useUser } from "../../context/UserContext";
import { STORAGE_KEY_USER } from "../../const/storageKeys";
import { orderClearHistory } from "../../api/order";

const ProfileActions = () => {
  const { user, setUser } = useUser();

  const handleLogoutClick = () => {
    console.log("Logout");
    if (window.confirm("Are you sure?")) {
      //Send an event to the paremt
      storageDelete(STORAGE_KEY_USER);
      setUser(null);
    }
  };

  const handleClearHistoryClick = async () => {
    if (
      !window.confirm(
        "Are you sure you want to delete all your pokemon..... \n they have lifes too you know"
      )
    ) { return; }
    

    const [clearError] = await orderClearHistory(user.id);

    if(clearError !== null){
      return;
    }
    
    const updatedUser = {
      ...user,
      pokemon: []
      
    }

    storageSave(STORAGE_KEY_USER, updatedUser);
    setUser(updatedUser);
  };

  return (
    <ul>
      <li>
        <Link to="/orders">Pokemon</Link>
      </li>
      <li>
        <button onClick={handleClearHistoryClick}>Clear Pokemon</button>
      </li>
      <li>
        <button onClick={handleLogoutClick}>Logout</button>
      </li>
    </ul>
  );
};

export default ProfileActions;
