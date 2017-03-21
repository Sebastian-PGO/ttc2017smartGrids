/**
 */
package CIM.IEC61968.AssetModels;

import java.util.Arrays;
import java.util.Collections;
import java.util.List;

import org.eclipse.emf.common.util.Enumerator;

/**
 * <!-- begin-user-doc -->
 * A representation of the literals of the enumeration '<em><b>Conductor Material Kind</b></em>',
 * and utility methods for working with them.
 * <!-- end-user-doc -->
 * @see CIM.IEC61968.AssetModels.AssetModelsPackage#getConductorMaterialKind()
 * @model
 * @generated
 */
public enum ConductorMaterialKind implements Enumerator {
	/**
	 * The '<em><b>Steel</b></em>' literal object.
	 * <!-- begin-user-doc -->
	 * <!-- end-user-doc -->
	 * @see #STEEL_VALUE
	 * @generated
	 * @ordered
	 */
	STEEL(0, "steel", "steel"),

	/**
	 * The '<em><b>Other</b></em>' literal object.
	 * <!-- begin-user-doc -->
	 * <!-- end-user-doc -->
	 * @see #OTHER_VALUE
	 * @generated
	 * @ordered
	 */
	OTHER(1, "other", "other"),

	/**
	 * The '<em><b>Aluminum</b></em>' literal object.
	 * <!-- begin-user-doc -->
	 * <!-- end-user-doc -->
	 * @see #ALUMINUM_VALUE
	 * @generated
	 * @ordered
	 */
	ALUMINUM(2, "aluminum", "aluminum"),

	/**
	 * The '<em><b>Copper</b></em>' literal object.
	 * <!-- begin-user-doc -->
	 * <!-- end-user-doc -->
	 * @see #COPPER_VALUE
	 * @generated
	 * @ordered
	 */
	COPPER(3, "copper", "copper"),

	/**
	 * The '<em><b>Acsr</b></em>' literal object.
	 * <!-- begin-user-doc -->
	 * <!-- end-user-doc -->
	 * @see #ACSR_VALUE
	 * @generated
	 * @ordered
	 */
	ACSR(4, "acsr", "acsr");

	/**
	 * The '<em><b>Steel</b></em>' literal value.
	 * <!-- begin-user-doc -->
	 * <p>
	 * If the meaning of '<em><b>Steel</b></em>' literal object isn't clear,
	 * there really should be more of a description here...
	 * </p>
	 * <!-- end-user-doc -->
	 * @see #STEEL
	 * @model name="steel"
	 * @generated
	 * @ordered
	 */
	public static final int STEEL_VALUE = 0;

	/**
	 * The '<em><b>Other</b></em>' literal value.
	 * <!-- begin-user-doc -->
	 * <p>
	 * If the meaning of '<em><b>Other</b></em>' literal object isn't clear,
	 * there really should be more of a description here...
	 * </p>
	 * <!-- end-user-doc -->
	 * @see #OTHER
	 * @model name="other"
	 * @generated
	 * @ordered
	 */
	public static final int OTHER_VALUE = 1;

	/**
	 * The '<em><b>Aluminum</b></em>' literal value.
	 * <!-- begin-user-doc -->
	 * <p>
	 * If the meaning of '<em><b>Aluminum</b></em>' literal object isn't clear,
	 * there really should be more of a description here...
	 * </p>
	 * <!-- end-user-doc -->
	 * @see #ALUMINUM
	 * @model name="aluminum"
	 * @generated
	 * @ordered
	 */
	public static final int ALUMINUM_VALUE = 2;

	/**
	 * The '<em><b>Copper</b></em>' literal value.
	 * <!-- begin-user-doc -->
	 * <p>
	 * If the meaning of '<em><b>Copper</b></em>' literal object isn't clear,
	 * there really should be more of a description here...
	 * </p>
	 * <!-- end-user-doc -->
	 * @see #COPPER
	 * @model name="copper"
	 * @generated
	 * @ordered
	 */
	public static final int COPPER_VALUE = 3;

	/**
	 * The '<em><b>Acsr</b></em>' literal value.
	 * <!-- begin-user-doc -->
	 * <p>
	 * If the meaning of '<em><b>Acsr</b></em>' literal object isn't clear,
	 * there really should be more of a description here...
	 * </p>
	 * <!-- end-user-doc -->
	 * @see #ACSR
	 * @model name="acsr"
	 * @generated
	 * @ordered
	 */
	public static final int ACSR_VALUE = 4;

	/**
	 * An array of all the '<em><b>Conductor Material Kind</b></em>' enumerators.
	 * <!-- begin-user-doc -->
	 * <!-- end-user-doc -->
	 * @generated
	 */
	private static final ConductorMaterialKind[] VALUES_ARRAY =
		new ConductorMaterialKind[] {
			STEEL,
			OTHER,
			ALUMINUM,
			COPPER,
			ACSR,
		};

	/**
	 * A public read-only list of all the '<em><b>Conductor Material Kind</b></em>' enumerators.
	 * <!-- begin-user-doc -->
	 * <!-- end-user-doc -->
	 * @generated
	 */
	public static final List<ConductorMaterialKind> VALUES = Collections.unmodifiableList(Arrays.asList(VALUES_ARRAY));

	/**
	 * Returns the '<em><b>Conductor Material Kind</b></em>' literal with the specified literal value.
	 * <!-- begin-user-doc -->
	 * <!-- end-user-doc -->
	 * @param literal the literal.
	 * @return the matching enumerator or <code>null</code>.
	 * @generated
	 */
	public static ConductorMaterialKind get(String literal) {
		for (int i = 0; i < VALUES_ARRAY.length; ++i) {
			ConductorMaterialKind result = VALUES_ARRAY[i];
			if (result.toString().equals(literal)) {
				return result;
			}
		}
		return null;
	}

	/**
	 * Returns the '<em><b>Conductor Material Kind</b></em>' literal with the specified name.
	 * <!-- begin-user-doc -->
	 * <!-- end-user-doc -->
	 * @param name the name.
	 * @return the matching enumerator or <code>null</code>.
	 * @generated
	 */
	public static ConductorMaterialKind getByName(String name) {
		for (int i = 0; i < VALUES_ARRAY.length; ++i) {
			ConductorMaterialKind result = VALUES_ARRAY[i];
			if (result.getName().equals(name)) {
				return result;
			}
		}
		return null;
	}

	/**
	 * Returns the '<em><b>Conductor Material Kind</b></em>' literal with the specified integer value.
	 * <!-- begin-user-doc -->
	 * <!-- end-user-doc -->
	 * @param value the integer value.
	 * @return the matching enumerator or <code>null</code>.
	 * @generated
	 */
	public static ConductorMaterialKind get(int value) {
		switch (value) {
			case STEEL_VALUE: return STEEL;
			case OTHER_VALUE: return OTHER;
			case ALUMINUM_VALUE: return ALUMINUM;
			case COPPER_VALUE: return COPPER;
			case ACSR_VALUE: return ACSR;
		}
		return null;
	}

	/**
	 * <!-- begin-user-doc -->
	 * <!-- end-user-doc -->
	 * @generated
	 */
	private final int value;

	/**
	 * <!-- begin-user-doc -->
	 * <!-- end-user-doc -->
	 * @generated
	 */
	private final String name;

	/**
	 * <!-- begin-user-doc -->
	 * <!-- end-user-doc -->
	 * @generated
	 */
	private final String literal;

	/**
	 * Only this class can construct instances.
	 * <!-- begin-user-doc -->
	 * <!-- end-user-doc -->
	 * @generated
	 */
	private ConductorMaterialKind(int value, String name, String literal) {
		this.value = value;
		this.name = name;
		this.literal = literal;
	}

	/**
	 * <!-- begin-user-doc -->
	 * <!-- end-user-doc -->
	 * @generated
	 */
	public int getValue() {
	  return value;
	}

	/**
	 * <!-- begin-user-doc -->
	 * <!-- end-user-doc -->
	 * @generated
	 */
	public String getName() {
	  return name;
	}

	/**
	 * <!-- begin-user-doc -->
	 * <!-- end-user-doc -->
	 * @generated
	 */
	public String getLiteral() {
	  return literal;
	}

	/**
	 * Returns the literal value of the enumerator, which is its string representation.
	 * <!-- begin-user-doc -->
	 * <!-- end-user-doc -->
	 * @generated
	 */
	@Override
	public String toString() {
		return literal;
	}
	
} //ConductorMaterialKind